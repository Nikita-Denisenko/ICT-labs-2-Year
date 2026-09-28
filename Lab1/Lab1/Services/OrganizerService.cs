using Lab1.Models;

namespace Lab1.Services
{
    public sealed class OrganizerService
    {
        private readonly List<OrganizerEvent> _events = new();

        public IReadOnlyCollection<OrganizerEvent> Events =>
            _events.AsReadOnly();

        public void Add(OrganizerEvent organizerEvent)
        {
            ArgumentNullException.ThrowIfNull(organizerEvent);

            _events.Add(organizerEvent);
        }

        public void Remove(OrganizerEvent organizerEvent)
        {
            ArgumentNullException.ThrowIfNull(organizerEvent);

            _events.Remove(organizerEvent);
        }

        public void Clear()
        {
            _events.Clear();
        }

        public List<OrganizerEvent> GetEvents(
            EventCategory? category = null,
            string? searchText = null,
            bool ascending = true)
        {
            IEnumerable<OrganizerEvent> query = _events;

            if (category.HasValue)
            {
                query = query.Where(
                    organizerEvent =>
                        organizerEvent.Category == category.Value);
            }

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(
                    organizerEvent =>
                        organizerEvent.Description.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase));
            }

            if (ascending)
            {
                return query
                    .OrderBy(organizerEvent => organizerEvent.Time)
                    .ThenBy(organizerEvent => organizerEvent.Date)
                    .ToList();
            }

            return query
                .OrderByDescending(organizerEvent => organizerEvent.Time)
                .ThenByDescending(organizerEvent => organizerEvent.Date)
                .ToList();
        }
    }
}