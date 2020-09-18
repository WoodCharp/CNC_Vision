namespace CNCV.Pages
{
    partial class Form_Machines
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
            this.machineList = new CCL.Controls.CListView();
            this.cButton_cancelMachineSave = new CCL.Controls.CButton();
            this.cButton_saveMachines = new CCL.Controls.CButton();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaxZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGRBLv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cContextMenuStrip1 = new CCL.Controls.CContextMenuStrip();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // machineList
            // 
            this.machineList.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.machineList.ColumnHeight = 24;
            this.machineList.Columns.Add(this.chID);
            this.machineList.Columns.Add(this.chName);
            this.machineList.Columns.Add(this.chType);
            this.machineList.Columns.Add(this.chMaxX);
            this.machineList.Columns.Add(this.chMaxY);
            this.machineList.Columns.Add(this.chMaxZ);
            this.machineList.Columns.Add(this.chGRBLv);
            this.machineList.Columns.Add(this.chOPT);
            this.machineList.ContentTextStyle = CCL.eTextStyle.Normal;
            this.machineList.ContextMenuStrip = this.cContextMenuStrip1;
            this.machineList.DrawBorder = true;
            this.machineList.EnableItemEdit = false;
            this.machineList.FullRowHoverEffect = true;
            this.machineList.HorizontalLines = true;
            this.machineList.ItemHeight = 24;
            this.machineList.ItemHoverEffect = true;
            this.machineList.Location = new System.Drawing.Point(12, 32);
            this.machineList.MinColumnWidth = 20;
            this.machineList.Name = "machineList";
            this.machineList.NoItemsToShowText = "No Items To Show.";
            this.machineList.NothingToShowText = "Nothing To Show.";
            this.machineList.Size = new System.Drawing.Size(776, 365);
            this.machineList.TabIndex = 0;
            this.machineList.TitleTextStyle = CCL.eTextStyle.Title3;
            this.machineList.VerticalLines = false;
            // 
            // cButton_cancelMachineSave
            // 
            this.cButton_cancelMachineSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_cancelMachineSave.DrawBorder = true;
            this.cButton_cancelMachineSave.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancelMachineSave.Location = new System.Drawing.Point(688, 403);
            this.cButton_cancelMachineSave.Name = "cButton_cancelMachineSave";
            this.cButton_cancelMachineSave.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancelMachineSave.TabIndex = 9;
            this.cButton_cancelMachineSave.Text = "Cancel";
            this.cButton_cancelMachineSave.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancelMachineSave.UseVisualStyleBackColor = true;
            this.cButton_cancelMachineSave.Click += new System.EventHandler(this.cButton_cancelMachineSave_Click);
            // 
            // cButton_saveMachines
            // 
            this.cButton_saveMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_saveMachines.DrawBorder = true;
            this.cButton_saveMachines.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_saveMachines.Location = new System.Drawing.Point(582, 403);
            this.cButton_saveMachines.Name = "cButton_saveMachines";
            this.cButton_saveMachines.Size = new System.Drawing.Size(100, 35);
            this.cButton_saveMachines.TabIndex = 8;
            this.cButton_saveMachines.Text = "Save";
            this.cButton_saveMachines.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_saveMachines.UseVisualStyleBackColor = true;
            this.cButton_saveMachines.Click += new System.EventHandler(this.cButton_saveMachines_Click);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 120;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 100;
            // 
            // chMaxX
            // 
            this.chMaxX.Text = "Max X";
            this.chMaxX.Width = 80;
            // 
            // chMaxY
            // 
            this.chMaxY.Text = "Max Y";
            this.chMaxY.Width = 80;
            // 
            // chMaxZ
            // 
            this.chMaxZ.Text = "Max Z";
            this.chMaxZ.Width = 80;
            // 
            // chGRBLv
            // 
            this.chGRBLv.Text = "GRBL v.";
            this.chGRBLv.Width = 120;
            // 
            // chOPT
            // 
            this.chOPT.Text = "OPT";
            this.chOPT.Width = 120;
            // 
            // cContextMenuStrip1
            // 
            this.cContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator2,
            this.reloadToolStripMenuItem});
            this.cContextMenuStrip1.Name = "cContextMenuStrip1";
            this.cContextMenuStrip1.Size = new System.Drawing.Size(125, 170);
            this.cContextMenuStrip1.TextStyle = CCL.eTextStyle.Normal;
            this.cContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.cContextMenuStrip1_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Form_Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cButton_cancelMachineSave);
            this.Controls.Add(this.cButton_saveMachines);
            this.Controls.Add(this.machineList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Machines";
            this.Sizable = false;
            this.Text = "Machines";
            this.cContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCL.Controls.CListView machineList;
        private CCL.Controls.CButton cButton_cancelMachineSave;
        private CCL.Controls.CButton cButton_saveMachines;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chMaxX;
        private System.Windows.Forms.ColumnHeader chMaxY;
        private System.Windows.Forms.ColumnHeader chMaxZ;
        private System.Windows.Forms.ColumnHeader chGRBLv;
        private System.Windows.Forms.ColumnHeader chOPT;
        private CCL.Controls.CContextMenuStrip cContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
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