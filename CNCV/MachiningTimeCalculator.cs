using CNCV.Machines;
using GRBL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCV
{
    public static class MachiningTimeCalculator
    {
        public static double GetMachiningTimeInSeconds(List<string> Lines, Machine machine, float startPosX, float startPosY, float startPosZ)
        {
            double totalTime = 0.0d;
            float currentFeedRate = 0;
            float currentPosX = startPosX, currentPosY = startPosY, currentPosZ = startPosZ;

            //G0 feed rates
            float xSpeed = machine.GetSettingValueByID(110);
            float ySpeed = machine.GetSettingValueByID(111);
            float zSpeed = machine.GetSettingValueByID(112);

            foreach (string line in Lines)
            {
                if(ValidLine(line))
                {
                    //Update current feed rate
                    if (line.StartsWith("G0"))
                    {
                        if (line.Contains("X") && !line.Contains("Y") && !line.Contains("Z"))
                            currentFeedRate = xSpeed;
                        else if (line.Contains("X") && line.Contains("Y") && !line.Contains("Z"))
                        {
                            //Not sure how grbl chooses to lower the value or how it calculates it, but for now choosing the lower one
                            if (xSpeed < ySpeed)
                                currentFeedRate = xSpeed;
                            else
                                currentFeedRate = ySpeed;
                        }
                        else if (!line.Contains("X") && line.Contains("Y") && !line.Contains("Z"))
                            currentFeedRate = ySpeed;
                        else if (!line.Contains("X") && !line.Contains("Y") && line.Contains("Z"))
                            currentFeedRate = zSpeed;
                    }
                    else if (line.Contains("F"))
                        currentFeedRate = GetFeedRate(line);

                    string editedLine = line;

                    //Remove commands to make value fetching easier
                    //Arc distances wont be calculated, yet
                    if(line.Contains("F"))
                        editedLine = editedLine.Substring(0, line.IndexOf('F'));

                    if (line.Contains("J"))
                        editedLine = editedLine.Substring(0, line.IndexOf('J'));

                    if (line.Contains("I"))
                        editedLine = editedLine.Substring(0, line.IndexOf('I'));

                    else if (line.Contains("X") && !line.Contains("Y") && !line.Contains("Z"))
                    {
                        totalTime += GetSeconds(GetDistance(currentPosX, GetOnlyX(editedLine)), (double)currentFeedRate);

                        currentPosX = (float)GetOnlyX(editedLine);
                    }
                    else if (!line.Contains("X") && line.Contains("Y") && !line.Contains("Z"))
                    {
                        totalTime += GetSeconds(GetDistance(currentPosY, GetOnlyY(editedLine)), (double)currentFeedRate);
                        currentPosY = (float)GetOnlyY(editedLine);
                    }
                    else if (line.Contains("X") && line.Contains("Y") && !line.Contains("Z"))
                    {
                        totalTime += GetSeconds(XY_Distance(currentPosX, GetXYZ_X(editedLine), currentPosY, GetOnlyY(editedLine)), (double)currentFeedRate);
                        currentPosX = (float)GetXYZ_X(editedLine);
                        currentPosY = (float)GetOnlyY(editedLine);
                    }
                    else if (!line.Contains("X") && !line.Contains("Y") && line.Contains("Z"))
                    {
                        totalTime += GetSeconds(GetDistance(currentPosZ, GetOnlyZ(editedLine)), (double)currentFeedRate);
                        currentPosZ = (float)GetOnlyZ(editedLine);
                    }
                    else if (line.Contains("X") && line.Contains("Y") && line.Contains("Z"))
                    {
                        totalTime += GetSeconds(XY_Distance(currentPosX, GetXYZ_X(editedLine), currentPosY, GetXYZ_Y(editedLine)), (double)currentFeedRate);
                        totalTime += GetSeconds(GetDistance(currentPosZ, GetOnlyZ(editedLine)), (double)currentFeedRate);

                        currentPosX = (float)GetXYZ_X(editedLine);
                        currentPosY = (float)GetXYZ_Y(editedLine);
                        currentPosZ = (float)GetOnlyZ(editedLine);
                    }
                }
            }

            return totalTime;
        }

        private static bool ValidLine(string line)
        {
            if (line[0] != 'M' || line[0] != 'T' || line[0] != '(')
            {
                if(line.Contains("X") || line.Contains("Y") || line.Contains("Z"))
                    return true;
            }

            return false;
        }

        private static double XY_Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static double GetDistance(double pos1, double pos2)
        {
            double distance = pos2 - pos1;
            if (distance < 0)
                distance = -distance;

            return distance;
        }

        private static double GetSeconds(double distance, double feedrate)
        {
            return (distance / feedrate) * 60d;
        }


        private static float GetFeedRate(string line)
        {
            return float.Parse(line.Split('F')[1].Replace('.', ','));
        }


        private static double GetOnlyX(string line)
        {
            return double.Parse(line.Split('X')[1].Replace('.',','));
        }

        private static double GetOnlyY(string line)
        {
            return double.Parse(line.Split('Y')[1].Replace('.', ','));
        }

        private static double GetOnlyZ(string line)
        {
            return double.Parse(line.Split('Z')[1].Replace('.', ','));
        }


        private static double GetXYZ_X(string line)
        {
            return double.Parse(line.Split('X', 'Y')[1].Replace('.', ','));
        }

        private static double GetXYZ_Y(string line)
        {
            return double.Parse(line.Split('Y', 'Z')[1].Replace('.', ','));
        }
    }
}
