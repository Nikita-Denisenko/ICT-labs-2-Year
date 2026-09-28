using Lab1.Services;

namespace Lab1.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            _userService = new UserService();

            toolTip.SetToolTip(
                textBoxLogin,
                "Enter your login.");

            toolTip.SetToolTip(
                textBoxPassword,
                "Enter your password.");
        }

        private void buttonLogin_Click(
            object sender,
            EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            if (_userService.Authenticate(login, password))
            {
                Hide();

                using OrganizerForm organizerForm = new OrganizerForm();

                organizerForm.ShowDialog();

                Close();

                return;
            }

            MessageBox.Show(
                "Wrong login or password!",
                "Authorization",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void checkBoxShowPassword_CheckedChanged(
            object sender,
            EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar =
                !checkBoxShowPassword.Checked;
        }

        private void buttonRegister_Click(
            object sender,
            EventArgs e)
        {
            using RegisterForm registerForm =
                new RegisterForm(_userService);

            registerForm.ShowDialog();
        }
    }
}