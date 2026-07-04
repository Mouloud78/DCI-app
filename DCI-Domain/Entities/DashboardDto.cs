
namespace DCI_Domain.Entities
{
    public class DashboardDto
    {
        public int TotalPatients { get; set; }
        public int TotalDoctors { get; set; }
        public int TodayAppointments { get; set; }
        public int PendingLabs { get; set; }
        public decimal MonthlyRevenue { get; set; }
    }
}
