namespace CNCV.Pages
{
    partial class Form_Tools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolsList = new CCL.Controls.CListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cButton_cancel = new CCL.Controls.CButton();
            this.cButton_saveTools = new CCL.Controls.CButton();
            this.cContextMenuStrip1 = new CCL.Controls.CContextMenuStrip();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsList
            // 
            this.toolsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsList.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.toolsList.ColumnHeight = 24;
            this.toolsList.Columns.Add(this.chID);
            this.toolsList.Columns.Add(this.chName);
            this.toolsList.Columns.Add(this.chType);
            this.toolsList.Columns.Add(this.chCD);
            this.toolsList.Columns.Add(this.chSD);
            this.toolsList.Columns.Add(this.chFL);
            this.toolsList.Columns.Add(this.chF);
            this.toolsList.Columns.Add(this.chA);
            this.toolsList.Columns.Add(this.chR);
            this.toolsList.Columns.Add(this.chMW);
            this.toolsList.ContentTextStyle = CCL.eTextStyle.Normal;
            this.toolsList.ContextMenuStrip = this.cContextMenuStrip1;
            this.toolsList.DrawBorder = true;
            this.toolsList.DropDownColumns.Add("2");
            this.toolsList.DropDownItems.Add("Flat Ball Carving Drill Chamfer Rounding Laser");
            this.toolsList.EnableItemEdit = true;
            this.toolsList.FullRowHoverEffect = false;
            this.toolsList.HorizontalLines = true;
            this.toolsList.ItemHeight = 24;
            this.toolsList.ItemHoverEffect = true;
            this.toolsList.Location = new System.Drawing.Point(12, 33);
            this.toolsList.MinColumnWidth = 20;
            this.toolsList.Name = "toolsList";
            this.toolsList.NoItemsToShowText = "No Items To Show.";
            this.toolsList.NothingToShowText = "Nothing To Show.";
            this.toolsList.Size = new System.Drawing.Size(738, 568);
            this.toolsList.TabIndex = 0;
            this.toolsList.TitleTextStyle = CCL.eTextStyle.Title3;
            this.toolsList.VerticalLines = false;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 100;
            // 
            // chCD
            // 
            this.chCD.Text = "CD";
            this.chCD.Width = 50;
            // 
            // chSD
            // 
            this.chSD.Text = "SD";
            this.chSD.Width = 50;
            // 
            // chFL
            // 
            this.chFL.Text = "FL";
            this.chFL.Width = 50;
            // 
            // chF
            // 
            this.chF.Text = "F";
            this.chF.Width = 50;
            // 
            // chA
            // 
            this.chA.Text = "A";
            this.chA.Width = 50;
            // 
            // chR
            // 
            this.chR.Text = "R";
            this.chR.Width = 50;
            // 
            // chMW
            // 
            this.chMW.Text = "mW";
            this.chMW.Width = 50;
            // 
            // cLabel1
            // 
            this.cLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(12, 604);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OverrideFontSize = 12F;
            this.cLabel1.Size = new System.Drawing.Size(492, 63);
            this.cLabel1.TabIndex = 3;
            this.cLabel1.Text = "INFO\r\nCD = Cutting Diameter SD = Shank Diameter FL = Flute Lenght\r\nF = Flutes A =" +
    " Angle R = Radius W = Watts";
            this.cLabel1.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel1.UseFontSizeOverride = false;
            // 
            // cButton_cancel
            // 
            this.cButton_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_cancel.DrawBorder = true;
            this.cButton_cancel.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancel.Location = new System.Drawing.Point(650, 629);
            this.cButton_cancel.Name = "cButton_cancel";
            this.cButton_cancel.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancel.TabIndex = 6;
            this.cButton_cancel.Text = "Cancel";
            this.cButton_cancel.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancel.UseVisualStyleBackColor = true;
            this.cButton_cancel.Click += new System.EventHandler(this.cButton_cancel_Click);
            // 
            // cButton_saveTools
            // 
            this.cButton_saveTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_saveTools.DrawBorder = true;
            this.cButton_saveTools.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_saveTools.Location = new System.Drawing.Point(544, 629);
            this.cButton_saveTools.Name = "cButton_saveTools";
            this.cButton_saveTools.Size = new System.Drawing.Size(100, 35);
            this.cButton_saveTools.TabIndex = 5;
            this.cButton_saveTools.Text = "Save";
            this.cButton_saveTools.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_saveTools.UseVisualStyleBackColor = true;
            this.cButton_saveTools.Click += new System.EventHandler(this.cButton_saveTools_Click);
            // 
            // cContextMenuStrip1
            // 
            this.cContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator2,
            this.reloadToolStripMenuItem});
            this.cContextMenuStrip1.Name = "cContextMenuStrip1";
            this.cContextMenuStrip1.Size = new System.Drawing.Size(125, 148);
            this.cContextMenuStrip1.TextStyle = CCL.eTextStyle.Normal;
            this.cContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.cContextMenuStrip1_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // Form_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 676);
            this.Controls.Add(this.cButton_cancel);
            this.Controls.Add(this.cButton_saveTools);
            this.Controls.Add(this.cLabel1);
            this.Controls.Add(this.toolsList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Tools";
            this.Sizable = false;
            this.Text = "Form_Tools";
            this.cContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCL.Controls.CListView toolsList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chCD;
        private System.Windows.Forms.ColumnHeader chSD;
        private System.Windows.Forms.ColumnHeader chFL;
        private System.Windows.Forms.ColumnHeader chF;
        private System.Windows.Forms.ColumnHeader chA;
        private System.Windows.Forms.ColumnHeader chR;
        private System.Windows.Forms.ColumnHeader chMW;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CButton cButton_cancel;
        private CCL.Controls.CButton cButton_saveTools;
        private CCL.Controls.CContextMenuStrip cContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}