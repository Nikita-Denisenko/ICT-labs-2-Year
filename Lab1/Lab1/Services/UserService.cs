using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Lab1.Models;

namespace Lab1.Services
{
    public sealed class UserService
    {
        private readonly string _filePath;

        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            WriteIndented = true
        };

        public UserService()
        {
            string dataDirectory = Path.Combine(
                AppContext.BaseDirectory,
                "Data");

            Directory.CreateDirectory(dataDirectory);

            _filePath = Path.Combine(
                dataDirectory,
                "users.json");

            EnsureFileExists();
        }

        public bool Register(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            List<User> users = LoadUsers();

            if (users.Any(x =>
                string.Equals(x.Login, login, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            users.Add(new User
            {
                Login = login.Trim(),
                PasswordHash = HashPassword(password)
            });

            SaveUsers(users);

            return true;
        }

        public bool Authenticate(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            List<User> users = LoadUsers();

            User? user = users.FirstOrDefault(x =>
                string.Equals(
                    x.Login,
                    login.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                return false;
            }

            string passwordHash = HashPassword(password);

            return string.Equals(
                user.PasswordHash,
                passwordHash,
                StringComparison.Ordinal);
        }

        private List<User> LoadUsers()
        {
            try
            {
                string json = File.ReadAllText(_filePath);

                return JsonSerializer.Deserialize<List<User>>(
                           json,
                           _jsonOptions)
                       ?? new List<User>();
            }
            catch
            {
                return new List<User>();
            }
        }

        private void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(
                users,
                _jsonOptions);

            File.WriteAllText(_filePath, json);
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        private static string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            byte[] hash = SHA256.HashData(bytes);

            return Convert.ToHexString(hash);
        }
    }
}