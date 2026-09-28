using Lab1.Services;

namespace Lab1.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm(UserService userService)
        {
            InitializeComponent();

            _userService = userService;
        }

        private void buttonRegister_Click(
            object sender,
            EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show(
                    "Enter login.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxLogin.Focus();

                return;
            }

            if (password.Length < 4)
            {
                MessageBox.Show(
                    "Password must contain at least 4 characters.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxPassword.Focus();

                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxConfirmPassword.Focus();

                return;
            }

            if (!_userService.Register(login, password))
            {
                MessageBox.Show(
                    "This login is already registered.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxLogin.Focus();

                return;
            }

            MessageBox.Show(
                "Registration completed successfully!",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkBoxShowPassword_CheckedChanged(
            object sender,
            EventArgs e)
        {
            bool showPassword = checkBoxShowPassword.Checked;

            textBoxPassword.UseSystemPasswordChar = !showPassword;
            textBoxConfirmPassword.UseSystemPasswordChar = !showPassword;
        }
    }
}