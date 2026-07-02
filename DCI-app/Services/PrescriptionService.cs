using DCI_app.Models;

namespace DCI_app.Services;

public class PrescriptionService
{
    private readonly List<Prescription> _prescriptions = new();

    public Task<List<Prescription>> GetByConsultationIdAsync(int consultationId)
    {
        var result = _prescriptions
            .Where(p => p.ConsultationId == consultationId)
            .ToList();

        return Task.FromResult(result);
    }

    public Task AddAsync(Prescription prescription)
    {
        prescription.Id = _prescriptions.Count + 1;

        _prescriptions.Add(prescription);

        return Task.CompletedTask;
    }
}