namespace Lab1.Models
{
    public sealed class User
    {
        public string Login { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;
    }
}