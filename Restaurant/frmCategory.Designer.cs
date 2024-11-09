namespace Restaurant
{
    partial class frmCategory
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
            this.components = new System.ComponentModel.Container();
            this.catNameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.catDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.clmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.Location = new System.Drawing.Point(355, 56);
            this.catNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.Size = new System.Drawing.Size(449, 26);
            this.catNameTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // catDescriptionTextBox
            // 
            this.catDescriptionTextBox.Location = new System.Drawing.Point(355, 108);
            this.catDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.catDescriptionTextBox.Multiline = true;
            this.catDescriptionTextBox.Name = "catDescriptionTextBox";
            this.catDescriptionTextBox.Size = new System.Drawing.Size(449, 309);
            this.catDescriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام رده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "توضیحات";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(355, 453);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(235, 50);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // grdCategories
            // 
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCategoryID,
            this.clmnCategoryName,
            this.clmnDescription,
            this.clmnDelete});
            this.grdCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCategories.Location = new System.Drawing.Point(0, 712);
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.RowHeadersWidth = 62;
            this.grdCategories.RowTemplate.Height = 28;
            this.grdCategories.Size = new System.Drawing.Size(1129, 344);
            this.grdCategories.TabIndex = 6;
            this.grdCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnCategoryID
            // 
            this.clmnCategoryID.DataPropertyName = "CategoryID";
            this.clmnCategoryID.HeaderText = "شناسه";
            this.clmnCategoryID.MinimumWidth = 6;
            this.clmnCategoryID.Name = "clmnCategoryID";
            this.clmnCategoryID.Visible = false;
            this.clmnCategoryID.Width = 125;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "نام رده";
            this.clmnCategoryName.MinimumWidth = 6;
            this.clmnCategoryName.Name = "clmnCategoryName";
            this.clmnCategoryName.Width = 125;
            // 
            // clmnDescription
            // 
            this.clmnDescription.DataPropertyName = "Description";
            this.clmnDescription.HeaderText = "توضیحات";
            this.clmnDescription.MinimumWidth = 6;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.Width = 125;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 1056);
            this.Controls.Add(this.grdCategories);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catDescriptionTextBox);
            this.Controls.Add(this.catNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دسته بندی";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox catNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox catDescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}