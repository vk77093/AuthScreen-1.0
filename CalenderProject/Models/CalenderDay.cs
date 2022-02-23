namespace CalenderProject.Models
{
    public class CalenderDay
    {
        public int? DayNumber { get; set; }
        public DateTime Date { get; set; }
        public bool IsEmpty { get; set; } //thats for calcuting the no. of emptyDays in Month
        public List<CalenderEvent> Events { get; set; }
    }
}
