namespace Lab1.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanel;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Button buttonRegister;
        private ToolTip toolTip;
        private FlowLayoutPanel buttonPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonPanel = new FlowLayoutPanel();
            buttonRegister = new Button();
            buttonLogin = new Button();
            toolTip = new ToolTip(components);
            tableLayoutPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelLogin, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxLogin, 1, 0);
            tableLayoutPanel.Controls.Add(labelPassword, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxPassword, 1, 1);
            tableLayoutPanel.Controls.Add(checkBoxShowPassword, 1, 2);
            tableLayoutPanel.Controls.Add(buttonPanel, 1, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(500, 260);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelLogin
            // 
            labelLogin.Dock = DockStyle.Fill;
            labelLogin.Location = new Point(23, 20);
            labelLogin.Name = "labelLogin";
            labelLogin.Padding = new Padding(0, 0, 10, 0);
            labelLogin.Size = new Size(124, 45);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login:";
            labelLogin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Dock = DockStyle.Fill;
            textBoxLogin.Location = new Point(153, 28);
            textBoxLogin.Margin = new Padding(3, 8, 3, 8);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(324, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Location = new Point(23, 65);
            labelPassword.Name = "labelPassword";
            labelPassword.Padding = new Padding(0, 0, 10, 0);
            labelPassword.Size = new Size(124, 45);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Location = new Point(153, 73);
            textBoxPassword.Margin = new Padding(3, 8, 3, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.Anchor = AnchorStyles.Left;
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(153, 120);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(108, 19);
            checkBoxShowPassword.TabIndex = 4;
            checkBoxShowPassword.Text = "Show password";
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(buttonRegister);
            buttonPanel.Controls.Add(buttonLogin);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonPanel.Location = new Point(153, 153);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(324, 84);
            buttonPanel.TabIndex = 5;
            buttonPanel.WrapContents = false;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(221, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(100, 32);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(115, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 32);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 260);
            Controls.Add(tableLayoutPanel);
            MinimumSize = new Size(420, 240);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}