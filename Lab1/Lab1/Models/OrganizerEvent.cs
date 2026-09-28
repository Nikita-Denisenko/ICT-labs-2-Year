namespace Lab1.Models
{
    public sealed class OrganizerEvent
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; } = string.Empty;

        public EventCategory Category { get; set; }

        public DateTime DateTime
        {
            get => Date.Date + Time;
        }

        public override string ToString()
        {
            return $"{Date:dd.MM.yyyy} / {Time:hh\\:mm} / {Description}";
        }
    }
}