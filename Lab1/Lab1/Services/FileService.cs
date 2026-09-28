using System.Text.Json;
using Lab1.Models;

namespace Lab1.Services
{
    public sealed class FileService
    {
        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true
        };

        public string DefaultDataDirectory =>
            Path.Combine(
                AppContext.BaseDirectory,
                "Data");

        public string DefaultFilePath =>
            Path.Combine(
                DefaultDataDirectory,
                "organizer.json");

        public void Save(
            string fileName,
            IEnumerable<OrganizerEvent> events)
        {
            string? directory =
                Path.GetDirectoryName(fileName);

            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json =
                JsonSerializer.Serialize(events, _options);

            File.WriteAllText(fileName, json);
        }

        public List<OrganizerEvent> Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<OrganizerEvent>();
            }

            string json = File.ReadAllText(fileName);

            return JsonSerializer.Deserialize<List<OrganizerEvent>>(
                       json)
                   ?? new List<OrganizerEvent>();
        }

        public void EnsureDefaultFileExists()
        {
            Directory.CreateDirectory(DefaultDataDirectory);

            if (!File.Exists(DefaultFilePath))
            {
                Save(
                    DefaultFilePath,
                    Array.Empty<OrganizerEvent>());
            }
        }
    }
}
