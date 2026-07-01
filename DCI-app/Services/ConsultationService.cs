using DCI_app.Models;

namespace DCI_app.Services;

public class ConsultationService
{
    private readonly List<Consultation> _consultations = new();

    public Task<List<Consultation>> GetByPatientIdAsync(int patientId)
    {
        return Task.FromResult(
            _consultations
                .Where(c => c.PatientId == patientId)
                .OrderByDescending(c => c.Date)
                .ToList()
        );
    }

    public Task AddAsync(Consultation consultation)
    {
        consultation.Id = _consultations.Count == 0 ? 1 : _consultations.Max(x => x.Id) + 1;
        _consultations.Add(consultation);
        return Task.CompletedTask;
    }
}