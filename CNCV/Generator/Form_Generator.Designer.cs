namespace CNCV.Generator
{
    partial class Form_Generator
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
            this.cMenuStrip1 = new CCL.Controls.CMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPanel1 = new CCL.Controls.CPanel();
            this.cTabSelector1 = new CCL.Controls.CTabSelector();
            this.cTabControlProperties = new CCL.Controls.CTabControl();
            this.tabPageProperties = new System.Windows.Forms.TabPage();
            this.tabPageWorkPiece = new System.Windows.Forms.TabPage();
            this.tabPageGCode = new System.Windows.Forms.TabPage();
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cFlowLayoutPanel1 = new CCL.Controls.CFlowLayoutPanel();
            this.cadDrawer1 = new CNCV.Controls.CADDrawer();
            this.shapeTemplate1 = new CNCV.Controls.ShapeTemplate();
            this.cMenuStrip1.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.cTabControlProperties.SuspendLayout();
            this.cFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMenuStrip1
            // 
            this.cMenuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cMenuStrip1.AutoSize = false;
            this.cMenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.cMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.cMenuStrip1.Location = new System.Drawing.Point(2, 24);
            this.cMenuStrip1.Name = "cMenuStrip1";
            this.cMenuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.cMenuStrip1.TabIndex = 0;
            this.cMenuStrip1.Text = "cMenuStrip1";
            this.cMenuStrip1.TextStyle = CCL.eTextStyle.Normal;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gCodeToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // gCodeToolStripMenuItem
            // 
            this.gCodeToolStripMenuItem.Name = "gCodeToolStripMenuItem";
            this.gCodeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gCodeToolStripMenuItem.Text = "G-Code";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cPanel1
            // 
            this.cPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPanel1.Controls.Add(this.cTabSelector1);
            this.cPanel1.Controls.Add(this.cTabControlProperties);
            this.cPanel1.Controls.Add(this.cLabel1);
            this.cPanel1.DrawBorder = true;
            this.cPanel1.Location = new System.Drawing.Point(777, 51);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Size = new System.Drawing.Size(257, 634);
            this.cPanel1.TabIndex = 2;
            // 
            // cTabSelector1
            // 
            this.cTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cTabSelector1.BaseTabControl = this.cTabControlProperties;
            this.cTabSelector1.DrawLineAllTheWay = true;
            this.cTabSelector1.Font = new System.Drawing.Font("Armata", 8F);
            this.cTabSelector1.IndicatorHeight = 4;
            this.cTabSelector1.LineHeight = 1;
            this.cTabSelector1.Location = new System.Drawing.Point(4, 37);
            this.cTabSelector1.Name = "cTabSelector1";
            this.cTabSelector1.SelectorHeight = 24;
            this.cTabSelector1.SelectorPadding = 10;
            this.cTabSelector1.Size = new System.Drawing.Size(249, 24);
            this.cTabSelector1.TabIndex = 3;
            this.cTabSelector1.TabsAlignment = CCL.Controls.CTabSelector.eTabsAlignment.Left;
            this.cTabSelector1.Text = "cTabSelector1";
            this.cTabSelector1.TextStyle = CCL.eTextStyle.Small;
            // 
            // cTabControlProperties
            // 
            this.cTabControlProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabControlProperties.Controls.Add(this.tabPageProperties);
            this.cTabControlProperties.Controls.Add(this.tabPageWorkPiece);
            this.cTabControlProperties.Controls.Add(this.tabPageGCode);
            this.cTabControlProperties.Location = new System.Drawing.Point(3, 68);
            this.cTabControlProperties.Name = "cTabControlProperties";
            this.cTabControlProperties.SelectedIndex = 0;
            this.cTabControlProperties.Size = new System.Drawing.Size(249, 564);
            this.cTabControlProperties.TabIndex = 0;
            // 
            // tabPageProperties
            // 
            this.tabPageProperties.Location = new System.Drawing.Point(4, 22);
            this.tabPageProperties.Name = "tabPageProperties";
            this.tabPageProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProperties.Size = new System.Drawing.Size(241, 538);
            this.tabPageProperties.TabIndex = 0;
            this.tabPageProperties.Text = "Properties";
            this.tabPageProperties.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkPiece
            // 
            this.tabPageWorkPiece.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkPiece.Name = "tabPageWorkPiece";
            this.tabPageWorkPiece.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkPiece.Size = new System.Drawing.Size(241, 581);
            this.tabPageWorkPiece.TabIndex = 1;
            this.tabPageWorkPiece.Text = "WorkPiece";
            this.tabPageWorkPiece.UseVisualStyleBackColor = true;
            // 
            // tabPageGCode
            // 
            this.tabPageGCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageGCode.Name = "tabPageGCode";
            this.tabPageGCode.Size = new System.Drawing.Size(241, 581);
            this.tabPageGCode.TabIndex = 2;
            this.tabPageGCode.Text = "G-Code";
            this.tabPageGCode.UseVisualStyleBackColor = true;
            // 
            // cLabel1
            // 
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 14F, System.Drawing.FontStyle.Bold);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(0, 0);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OverrideFontSize = 12F;
            this.cLabel1.Size = new System.Drawing.Size(257, 34);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "Properties";
            this.cLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel1.TextStyle = CCL.eTextStyle.Title4;
            this.cLabel1.UseFontSizeOverride = false;
            // 
            // cFlowLayoutPanel1
            // 
            this.cFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cFlowLayoutPanel1.Controls.Add(this.shapeTemplate1);
            this.cFlowLayoutPanel1.DrawBorder = true;
            this.cFlowLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.cFlowLayoutPanel1.Name = "cFlowLayoutPanel1";
            this.cFlowLayoutPanel1.Size = new System.Drawing.Size(176, 634);
            this.cFlowLayoutPanel1.TabIndex = 3;
            // 
            // cadDrawer1
            // 
            this.cadDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadDrawer1.BackgroundColor = System.Drawing.Color.LightGray;
            this.cadDrawer1.GridColor = System.Drawing.Color.Black;
            this.cadDrawer1.GridDotSize = 2;
            this.cadDrawer1.GridSize = 40F;
            this.cadDrawer1.Location = new System.Drawing.Point(182, 51);
            this.cadDrawer1.Name = "cadDrawer1";
            this.cadDrawer1.Size = new System.Drawing.Size(589, 634);
            this.cadDrawer1.TabIndex = 4;
            this.cadDrawer1.Text = "cadDrawer1";
            // 
            // shapeTemplate1
            // 
            this.shapeTemplate1.FixedSize = new System.Drawing.Size(150, 35);
            this.shapeTemplate1.ID = 0;
            this.shapeTemplate1.Location = new System.Drawing.Point(3, 3);
            this.shapeTemplate1.Name = "shapeTemplate1";
            this.shapeTemplate1.Size = new System.Drawing.Size(150, 35);
            this.shapeTemplate1.TabIndex = 0;
            this.shapeTemplate1.TemplateImage = global::CNCV.Properties.Resources.ShapeTemplate_Rectangle;
            this.shapeTemplate1.Text = "Rectangle";
            // 
            // Form_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 697);
            this.Controls.Add(this.cadDrawer1);
            this.Controls.Add(this.cFlowLayoutPanel1);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.cMenuStrip1);
            this.MainMenuStrip = this.cMenuStrip1;
            this.Name = "Form_Generator";
            this.Text = "G-Code Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Generator_FormClosing);
            this.cMenuStrip1.ResumeLayout(false);
            this.cMenuStrip1.PerformLayout();
            this.cPanel1.ResumeLayout(false);
            this.cTabControlProperties.ResumeLayout(false);
            this.cFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCL.Controls.CMenuStrip cMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private CCL.Controls.CPanel cPanel1;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CTabControl cTabControlProperties;
        private System.Windows.Forms.TabPage tabPageProperties;
        private System.Windows.Forms.TabPage tabPageWorkPiece;
        private CCL.Controls.CTabSelector cTabSelector1;
        private System.Windows.Forms.TabPage tabPageGCode;
        private CCL.Controls.CFlowLayoutPanel cFlowLayoutPanel1;
        private Controls.ShapeTemplate shapeTemplate1;
        private Controls.CADDrawer cadDrawer1;
    }
}