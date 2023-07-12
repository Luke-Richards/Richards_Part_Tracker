
using System.Windows.Forms;

namespace Richards_Part_Tracker
{
    partial class PartTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartTracker));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSearch = new WindowsFormsAero.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.viewPartTracker = new System.Windows.Forms.ListView();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbBin = new System.Windows.Forms.CheckBox();
            this.cbQuantity = new System.Windows.Forms.CheckBox();
            this.cbDesc = new System.Windows.Forms.CheckBox();
            this.cbSearch = new System.Windows.Forms.CheckBox();
            this.lblFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.lblFound);
            this.splitContainer1.Panel1.Controls.Add(this.cbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cbDesc);
            this.splitContainer1.Panel1.Controls.Add(this.cbQuantity);
            this.splitContainer1.Panel1.Controls.Add(this.cbBin);
            this.splitContainer1.Panel1.Controls.Add(this.cbName);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.viewPartTracker);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(430, 624);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.CueBannerText = "Search";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Part";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // viewPartTracker
            // 
            this.viewPartTracker.BackColor = System.Drawing.SystemColors.Window;
            this.viewPartTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPartTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPartTracker.FullRowSelect = true;
            this.viewPartTracker.GridLines = true;
            this.viewPartTracker.HideSelection = false;
            this.viewPartTracker.Location = new System.Drawing.Point(10, 0);
            this.viewPartTracker.Name = "viewPartTracker";
            this.viewPartTracker.Size = new System.Drawing.Size(410, 408);
            this.viewPartTracker.TabIndex = 0;
            this.viewPartTracker.UseCompatibleStateImageBehavior = false;
            this.viewPartTracker.View = System.Windows.Forms.View.Details;
            this.viewPartTracker.SelectedIndexChanged += new System.EventHandler(this.viewPartTracker_SelectedIndexChanged);
            this.viewPartTracker.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.viewPartTracker_MouseDoubleClick);
            // 
            // cbName
            // 
            this.cbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(108, 162);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(63, 20);
            this.cbName.TabIndex = 5;
            this.cbName.Text = "name";
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // cbBin
            // 
            this.cbBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBin.AutoSize = true;
            this.cbBin.Checked = true;
            this.cbBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBin.Location = new System.Drawing.Point(177, 162);
            this.cbBin.Name = "cbBin";
            this.cbBin.Size = new System.Drawing.Size(58, 20);
            this.cbBin.TabIndex = 6;
            this.cbBin.Text = "Bin #";
            this.cbBin.UseVisualStyleBackColor = true;
            this.cbBin.CheckedChanged += new System.EventHandler(this.cbBin_CheckedChanged);
            // 
            // cbQuantity
            // 
            this.cbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbQuantity.AutoSize = true;
            this.cbQuantity.Checked = true;
            this.cbQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQuantity.Location = new System.Drawing.Point(241, 162);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(77, 20);
            this.cbQuantity.TabIndex = 7;
            this.cbQuantity.Text = "Quantity";
            this.cbQuantity.UseVisualStyleBackColor = true;
            this.cbQuantity.CheckedChanged += new System.EventHandler(this.cbQuantity_CheckedChanged);
            // 
            // cbDesc
            // 
            this.cbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDesc.AutoSize = true;
            this.cbDesc.Checked = true;
            this.cbDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDesc.Location = new System.Drawing.Point(324, 162);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(97, 20);
            this.cbDesc.TabIndex = 8;
            this.cbDesc.Text = "Description";
            this.cbDesc.UseVisualStyleBackColor = true;
            this.cbDesc.CheckedChanged += new System.EventHandler(this.cbDesc_CheckedChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSearch.AutoSize = true;
            this.cbSearch.Checked = true;
            this.cbSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearch.Location = new System.Drawing.Point(13, 162);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(89, 20);
            this.cbSearch.TabIndex = 9;
            this.cbSearch.Text = "Search all";
            this.cbSearch.UseVisualStyleBackColor = true;
            this.cbSearch.CheckedChanged += new System.EventHandler(this.cbSearch_CheckedChanged);
            // 
            // lblFound
            // 
            this.lblFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFound.AutoSize = true;
            this.lblFound.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFound.Location = new System.Drawing.Point(241, 136);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(56, 16);
            this.lblFound.TabIndex = 10;
            this.lblFound.Text = "0 results";
            // 
            // PartTracker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 624);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartTracker";
            this.Text = "Richards Part Tracker";
            this.ResizeEnd += new System.EventHandler(this.PartTracker_ResizeEnd);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView viewPartTracker;
        private System.Windows.Forms.Button btnAdd;
        private WindowsFormsAero.TextBox txtSearch;
        private CheckBox cbDesc;
        private CheckBox cbQuantity;
        private CheckBox cbBin;
        private CheckBox cbName;
        private CheckBox cbSearch;
        private Label lblFound;
    }
}

