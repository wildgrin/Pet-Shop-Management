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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            txtPass = new TextBox();
            label4 = new Label();
            dtDob = new DateTimePicker();
            label7 = new Label();
            cbRole = new ComboBox();
            label8 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 14);
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
            label1.Size = new Size(238, 34);
            label1.TabIndex = 1;
            label1.Text = "User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(523, 30);
            txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(219, 204);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(523, 30);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 207);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 8;
            label5.Text = "Phone:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(219, 151);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(523, 30);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 154);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 10;
            label6.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 260);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 12;
            label3.Text = "Role:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(219, 361);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(523, 30);
            txtPass.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 366);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // dtDob
            // 
            dtDob.Location = new Point(219, 310);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(523, 30);
            dtDob.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 313);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 17;
            label7.Text = "Date Of Birth:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrator", "Cashier", "Employee" });
            cbRole.Location = new Point(219, 257);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(523, 29);
            cbRole.TabIndex = 18;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 447);
            label8.Name = "label8";
            label8.Size = new Size(36, 21);
            label8.TabIndex = 19;
            label8.Text = "uid";
            label8.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(219, 428);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 50);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 132, 44);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(403, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 50);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(586, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 50);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(740, 14);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(44, 29);
            btnClose.TabIndex = 23;
            btnClose.Text = "X";
            btnClose.Click += btnClose_Click;
            // 
            // UserModule
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 514);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(cbRole);
            Controls.Add(label7);
            Controls.Add(dtDob);
            Controls.Add(txtPass);
            Controls.Add(label4);
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
            Text = "UserModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label label7;
        private DateTimePicker dtDob;
        private TextBox txtPass;
        private Label label4;
        private Label label3;
        private Button btnSave;
        private Label label8;
        private ComboBox cbRole;
        private Button btnCancel;
        private Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}