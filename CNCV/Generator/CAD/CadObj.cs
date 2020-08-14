using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCV.Generator.CAD
{
    public enum CadObjType
    {
        Rectangle
    }

    public class CadObj
    {
        public CadObjType ObjType { get; set; }

        public Size Size { get; set; }
        public Point Location { get; set; }


    }
}
