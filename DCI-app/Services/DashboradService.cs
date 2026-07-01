using DCI_app.Models;

namespace DCI_app.Services;

public class DashboardService
{
    public Task<DashboardDto> GetDashboardAsync()
    {
        // simulation 
        var data = new DashboardDto
        {
            TotalPatients = 128,
            TotalDoctors = 12,
            TodayAppointments = 24,
            PendingLabs = 7,
            MonthlyRevenue = 15420.50m
        };

        return Task.FromResult(data);
    }
}