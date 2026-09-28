namespace Lab1.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer? components = null;

        private TableLayoutPanel tableLayoutPanel;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonRegister;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonsPanel = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonRegister = new Button();
            tableLayoutPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelLogin, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxLogin, 1, 0);
            tableLayoutPanel.Controls.Add(labelPassword, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxPassword, 1, 1);
            tableLayoutPanel.Controls.Add(labelConfirmPassword, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxConfirmPassword, 1, 2);
            tableLayoutPanel.Controls.Add(checkBoxShowPassword, 1, 3);
            tableLayoutPanel.Controls.Add(buttonsPanel, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(15);
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.Size = new Size(500, 270);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelLogin
            // 
            labelLogin.Dock = DockStyle.Fill;
            labelLogin.Location = new Point(18, 15);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(144, 45);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login:";
            labelLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Dock = DockStyle.Fill;
            textBoxLogin.Location = new Point(168, 18);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(314, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Location = new Point(18, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(144, 45);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Location = new Point(168, 63);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(314, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.Dock = DockStyle.Fill;
            labelConfirmPassword.Location = new Point(18, 105);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(144, 45);
            labelConfirmPassword.TabIndex = 4;
            labelConfirmPassword.Text = "Confirm password:";
            labelConfirmPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Dock = DockStyle.Fill;
            textBoxConfirmPassword.Location = new Point(168, 108);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(314, 23);
            textBoxConfirmPassword.TabIndex = 5;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(168, 153);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(108, 19);
            checkBoxShowPassword.TabIndex = 6;
            checkBoxShowPassword.Text = "Show password";
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(buttonCancel);
            buttonsPanel.Controls.Add(buttonRegister);
            buttonsPanel.Location = new Point(168, 193);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(200, 59);
            buttonsPanel.TabIndex = 7;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 0);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            // 
            // buttonRegister
            // 
            buttonRegister.Dock = DockStyle.Fill;
            buttonRegister.Location = new Point(84, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 0);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register";
            buttonRegister.Click += buttonRegister_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = buttonRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(500, 270);
            Controls.Add(tableLayoutPanel);
            MinimumSize = new Size(450, 250);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registration";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private FlowLayoutPanel buttonsPanel;
    }
}
