namespace Pet_Shop_Management
{
    partial class ProductModule
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
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblPcode = new Label();
            cbCategory = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            txtType = new TextBox();
            txtQty = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label6 = new Label();
            panel1 = new Panel();
            txtPrice = new TextBox();
            SuspendLayout();
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
            btnClose.Location = new Point(664, 0);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(44, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(524, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 50);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 132, 44);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(371, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 50);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(219, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPcode
            // 
            lblPcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPcode.AutoSize = true;
            lblPcode.Location = new Point(40, 362);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new Size(59, 20);
            lblPcode.TabIndex = 38;
            lblPcode.Text = "pcode";
            lblPcode.Visible = false;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Dog", "Cat", "Bird", "Fish", "Food" });
            cbCategory.Location = new Point(219, 198);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(447, 28);
            cbCategory.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 283);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 37;
            label7.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 242);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 35;
            label3.Text = "Quantity:";
            // 
            // txtType
            // 
            txtType.Location = new Point(219, 157);
            txtType.Name = "txtType";
            txtType.Size = new Size(447, 26);
            txtType.TabIndex = 1;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(219, 241);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(447, 26);
            txtQty.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 201);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 32;
            label5.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 26);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 119);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 24;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(26, 50);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 22;
            label1.Text = "Product Registration";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 160);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 34;
            label6.Text = "Type:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 14);
            panel1.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(219, 280);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(447, 26);
            txtPrice.TabIndex = 4;
            // 
            // ProductModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 414);
            Controls.Add(txtPrice);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblPcode);
            Controls.Add(cbCategory);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(txtType);
            Controls.Add(txtQty);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public Label lblPcode;
        public ComboBox cbCategory;
        private Label label7;
        private Label label3;
        public TextBox txtType;
        public TextBox txtQty;
        private Label label5;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label6;
        private Panel panel1;
        public TextBox txtPrice;
    }
}