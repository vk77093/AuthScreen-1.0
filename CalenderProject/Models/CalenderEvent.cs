using CalenderProject.Pages.CalenderComponents.Helper;

namespace CalenderProject.Models
{
    public class CalenderEvent
    {
        public CalenderEvent()
        {
            Color=RandomColorGen.GetRandomColorClasses();
        }
        public string? Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Color { get; private set; }
    }
}
