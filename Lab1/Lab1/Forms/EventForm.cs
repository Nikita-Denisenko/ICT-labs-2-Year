using Lab1.Models;

namespace Lab1.Forms
{
    public partial class EventForm : Form
    {
        private readonly OrganizerEvent? _event;

        public OrganizerEvent? Result { get; private set; }

        public EventForm(
            OrganizerEvent? organizerEvent = null)
        {
            InitializeComponent();

            _event = organizerEvent;

            comboBoxCategory.DataSource =
                Enum.GetValues<EventCategory>();

            if (_event == null)
            {
                Text = "Add event";

                monthCalendar.SetDate(
                    DateTime.Today);

                dateTimePickerTime.Value =
                    DateTime.Now;

                comboBoxCategory.SelectedIndex = 0;

                return;
            }

            Text = "Edit event";

            monthCalendar.SetDate(
                _event.Date);

            dateTimePickerTime.Value =
                DateTime.Today.Add(
                    _event.Time);

            textBoxDescription.Text =
                _event.Description;

            comboBoxCategory.SelectedItem =
                _event.Category;
        }

        private void buttonOk_Click(
            object? sender,
            EventArgs e)
        {
            DateTime selectedDate =
                monthCalendar.SelectionStart.Date;

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show(
                    "You cannot add an event for a date that has already passed.",
                    "Invalid date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(
                    textBoxDescription.Text))
            {
                MessageBox.Show(
                    "Enter event description.",
                    "Invalid data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxDescription.Focus();

                return;
            }

            TimeSpan selectedTime =
                dateTimePickerTime.Value.TimeOfDay;

            Result = new OrganizerEvent
            {
                Date = selectedDate,
                Time = selectedTime,
                Description =
                    textBoxDescription.Text.Trim(),

                Category =
                    (EventCategory)
                    comboBoxCategory.SelectedItem!
            };

            DialogResult =
                DialogResult.OK;

            Close();
        }

        private void buttonCancel_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }
    }
}
