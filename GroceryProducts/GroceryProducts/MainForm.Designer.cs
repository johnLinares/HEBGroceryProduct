namespace GroceryProducts
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvDisplayTable = new System.Windows.Forms.DataGridView();
            this.tbxSearchBarForCrit1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitleSearchBar = new System.Windows.Forms.Label();
            this.lblTitleCriteria = new System.Windows.Forms.Label();
            this.cbxCriteria1 = new System.Windows.Forms.ComboBox();
            this.tbxSearchBarForCrit2 = new System.Windows.Forms.TextBox();
            this.tbxSearchBarForCrit3 = new System.Windows.Forms.TextBox();
            this.cbxCriteria2 = new System.Windows.Forms.ComboBox();
            this.cbxCriteria3 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.lblTITLESearchAmount = new System.Windows.Forms.Label();
            this.lblSearchAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayTable
            // 
            this.dgvDisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDisplayTable, "dgvDisplayTable");
            this.dgvDisplayTable.Name = "dgvDisplayTable";
            // 
            // tbxSearchBarForCrit1
            // 
            resources.ApplyResources(this.tbxSearchBarForCrit1, "tbxSearchBarForCrit1");
            this.tbxSearchBarForCrit1.Name = "tbxSearchBarForCrit1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            resources.ApplyResources(this.loadDataToolStripMenuItem, "loadDataToolStripMenuItem");
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbxIcon
            // 
            resources.ApplyResources(this.pbxIcon, "pbxIcon");
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.TabStop = false;
            // 
            // lblTitleSearchBar
            // 
            resources.ApplyResources(this.lblTitleSearchBar, "lblTitleSearchBar");
            this.lblTitleSearchBar.Name = "lblTitleSearchBar";
            // 
            // lblTitleCriteria
            // 
            resources.ApplyResources(this.lblTitleCriteria, "lblTitleCriteria");
            this.lblTitleCriteria.Name = "lblTitleCriteria";
            // 
            // cbxCriteria1
            // 
            resources.ApplyResources(this.cbxCriteria1, "cbxCriteria1");
            this.cbxCriteria1.FormattingEnabled = true;
            this.cbxCriteria1.Items.AddRange(new object[] {
            resources.GetString("cbxCriteria1.Items"),
            resources.GetString("cbxCriteria1.Items1"),
            resources.GetString("cbxCriteria1.Items2"),
            resources.GetString("cbxCriteria1.Items3"),
            resources.GetString("cbxCriteria1.Items4"),
            resources.GetString("cbxCriteria1.Items5"),
            resources.GetString("cbxCriteria1.Items6"),
            resources.GetString("cbxCriteria1.Items7"),
            resources.GetString("cbxCriteria1.Items8")});
            this.cbxCriteria1.Name = "cbxCriteria1";
            // 
            // tbxSearchBarForCrit2
            // 
            resources.ApplyResources(this.tbxSearchBarForCrit2, "tbxSearchBarForCrit2");
            this.tbxSearchBarForCrit2.Name = "tbxSearchBarForCrit2";
            // 
            // tbxSearchBarForCrit3
            // 
            resources.ApplyResources(this.tbxSearchBarForCrit3, "tbxSearchBarForCrit3");
            this.tbxSearchBarForCrit3.Name = "tbxSearchBarForCrit3";
            // 
            // cbxCriteria2
            // 
            resources.ApplyResources(this.cbxCriteria2, "cbxCriteria2");
            this.cbxCriteria2.FormattingEnabled = true;
            this.cbxCriteria2.Items.AddRange(new object[] {
            resources.GetString("cbxCriteria2.Items"),
            resources.GetString("cbxCriteria2.Items1"),
            resources.GetString("cbxCriteria2.Items2"),
            resources.GetString("cbxCriteria2.Items3"),
            resources.GetString("cbxCriteria2.Items4"),
            resources.GetString("cbxCriteria2.Items5"),
            resources.GetString("cbxCriteria2.Items6"),
            resources.GetString("cbxCriteria2.Items7"),
            resources.GetString("cbxCriteria2.Items8")});
            this.cbxCriteria2.Name = "cbxCriteria2";
            // 
            // cbxCriteria3
            // 
            resources.ApplyResources(this.cbxCriteria3, "cbxCriteria3");
            this.cbxCriteria3.FormattingEnabled = true;
            this.cbxCriteria3.Items.AddRange(new object[] {
            resources.GetString("cbxCriteria3.Items"),
            resources.GetString("cbxCriteria3.Items1"),
            resources.GetString("cbxCriteria3.Items2"),
            resources.GetString("cbxCriteria3.Items3"),
            resources.GetString("cbxCriteria3.Items4"),
            resources.GetString("cbxCriteria3.Items5"),
            resources.GetString("cbxCriteria3.Items6"),
            resources.GetString("cbxCriteria3.Items7"),
            resources.GetString("cbxCriteria3.Items8")});
            this.cbxCriteria3.Name = "cbxCriteria3";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearData
            // 
            resources.ApplyResources(this.btnClearData, "btnClearData");
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // lblTITLESearchAmount
            // 
            resources.ApplyResources(this.lblTITLESearchAmount, "lblTITLESearchAmount");
            this.lblTITLESearchAmount.Name = "lblTITLESearchAmount";
            // 
            // lblSearchAmount
            // 
            resources.ApplyResources(this.lblSearchAmount, "lblSearchAmount");
            this.lblSearchAmount.Name = "lblSearchAmount";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchAmount);
            this.Controls.Add(this.lblTITLESearchAmount);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCriteria3);
            this.Controls.Add(this.cbxCriteria2);
            this.Controls.Add(this.tbxSearchBarForCrit3);
            this.Controls.Add(this.tbxSearchBarForCrit2);
            this.Controls.Add(this.cbxCriteria1);
            this.Controls.Add(this.lblTitleCriteria);
            this.Controls.Add(this.tbxSearchBarForCrit1);
            this.Controls.Add(this.lblTitleSearchBar);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.dgvDisplayTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayTable;
        private System.Windows.Forms.TextBox tbxSearchBarForCrit1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblTitleSearchBar;
        private System.Windows.Forms.Label lblTitleCriteria;
        private System.Windows.Forms.ComboBox cbxCriteria1;
        private System.Windows.Forms.TextBox tbxSearchBarForCrit2;
        private System.Windows.Forms.TextBox tbxSearchBarForCrit3;
        private System.Windows.Forms.ComboBox cbxCriteria2;
        private System.Windows.Forms.ComboBox cbxCriteria3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label lblTITLESearchAmount;
        private System.Windows.Forms.Label lblSearchAmount;
    }
}

