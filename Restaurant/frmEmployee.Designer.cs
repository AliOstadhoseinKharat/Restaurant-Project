namespace Restaurant
{
    partial class frmEmployee
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDeActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.clmnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(128, 104);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(256, 26);
            this.firstNameInput.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(100, 107);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(22, 20);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "نام";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(456, 172);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(42, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "پسورد";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(511, 169);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(256, 26);
            this.passwordInput.TabIndex = 4;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(432, 104);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(66, 20);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "نام کاربری";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(511, 101);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(256, 26);
            this.userNameInput.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(49, 168);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "نام خانوادگی";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(128, 162);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(256, 26);
            this.lastNameInput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDeActive);
            this.groupBox1.Controls.Add(this.rdbActive);
            this.groupBox1.Location = new System.Drawing.Point(128, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فعالیت";
            // 
            // rdbDeActive
            // 
            this.rdbDeActive.AutoSize = true;
            this.rdbDeActive.Location = new System.Drawing.Point(84, 37);
            this.rdbDeActive.Name = "rdbDeActive";
            this.rdbDeActive.Size = new System.Drawing.Size(73, 24);
            this.rdbDeActive.TabIndex = 1;
            this.rdbDeActive.Text = "غیر فعال";
            this.rdbDeActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Location = new System.Drawing.Point(365, 37);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(49, 24);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "فعال";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "ثبت جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(965, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(965, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "بازگشت";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grdEmployees
            // 
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEmployeeID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnUserName,
            this.clmnIsActive,
            this.clmnDelete});
            this.grdEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdEmployees.Location = new System.Drawing.Point(0, 411);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.Size = new System.Drawing.Size(1182, 281);
            this.grdEmployees.TabIndex = 13;
            this.grdEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployees_CellContentClick);
            // 
            // clmnEmployeeID
            // 
            this.clmnEmployeeID.DataPropertyName = "EmployeeID";
            this.clmnEmployeeID.HeaderText = "کد کارمندی";
            this.clmnEmployeeID.Name = "clmnEmployeeID";
            this.clmnEmployeeID.Visible = false;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.DataPropertyName = "FirstName";
            this.clmnFirstName.HeaderText = "نام";
            this.clmnFirstName.Name = "clmnFirstName";
            // 
            // clmnLastName
            // 
            this.clmnLastName.DataPropertyName = "LastName";
            this.clmnLastName.HeaderText = "نام خانوادگی";
            this.clmnLastName.Name = "clmnLastName";
            // 
            // clmnUserName
            // 
            this.clmnUserName.DataPropertyName = "UserName";
            this.clmnUserName.HeaderText = "نام کاربری";
            this.clmnUserName.Name = "clmnUserName";
            // 
            // clmnIsActive
            // 
            this.clmnIsActive.DataPropertyName = "IsActive";
            this.clmnIsActive.HeaderText = "فعال";
            this.clmnIsActive.Name = "clmnIsActive";
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 692);
            this.Controls.Add(this.grdEmployees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت کارمندان";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDeActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}