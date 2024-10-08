namespace Pet_Shop_Management
{
    partial class UserModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            label3 = new Label();
            dtDob = new DateTimePicker();
            label7 = new Label();
            cbRole = new ComboBox();
            lbluid = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            lblPass = new Label();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 14);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 1;
            label1.Text = "User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 25);
            txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(219, 183);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(447, 25);
            txtPhone.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 186);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(219, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(447, 25);
            txtAddress.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 144);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 10;
            label6.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 226);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 12;
            label3.Text = "Role:";
            // 
            // dtDob
            // 
            dtDob.Location = new Point(219, 267);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(447, 25);
            dtDob.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 268);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 17;
            label7.Text = "Date Of Birth:";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrator", "Cashier", "Employee" });
            cbRole.Location = new Point(219, 223);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(447, 27);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // lbluid
            // 
            lbluid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbluid.AutoSize = true;
            lbluid.Location = new Point(40, 383);
            lbluid.Name = "lbluid";
            lbluid.Size = new Size(31, 20);
            lbluid.TabIndex = 19;
            lbluid.Text = "uid";
            lbluid.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(219, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 132, 44);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(371, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 50);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(525, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 50);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges5;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(664, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.Size = new Size(44, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.Click += btnClose_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(26, 310);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 20);
            lblPass.TabIndex = 14;
            lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(219, 309);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(447, 25);
            txtPass.TabIndex = 5;
            // 
            // UserModule
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 453);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lbluid);
            Controls.Add(cbRole);
            Controls.Add(label7);
            Controls.Add(dtDob);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label3;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        public Label lbluid;
        public TextBox txtAddress;
        public TextBox txtPhone;
        public TextBox txtName;
        public DateTimePicker dtDob;
        public Button btnSave;
        public ComboBox cbRole;
        public Button btnUpdate;
        public TextBox txtPass;
        private Label lblPass;
    }
}