using DCI_Domain.Entities;
using DCI_Domain.Enums;

namespace DCI_app.Services;

public class MedicalHistoryService
{
    private readonly List<MedicalHistory> _histories = new();

    public Task<List<MedicalHistory>> GetByPatientIdAsync(int patientId)
    {
        var result = _histories
            .Where(h => h.PatientId == patientId)
            .OrderByDescending(h => h.Date)
            .ToList();

        return Task.FromResult(result);
    }

    public Task AddAsync(MedicalHistory history)
    {
        history.Id = _histories.Count == 0 ? 1 : _histories.Max(x => x.Id) + 1;
        _histories.Add(history);
        return Task.CompletedTask;
    }
}