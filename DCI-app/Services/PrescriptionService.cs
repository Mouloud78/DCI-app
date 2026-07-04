using DCI_Domain.Entities;
using DCI_Domain.Enums;

namespace DCI_app.Services;

public class PrescriptionService
{
    private readonly List<Prescription> _prescriptions = new();

    public Task<List<Prescription>> GetByConsultationIdAsync(int consultationId)
    {
        return Task.FromResult(
            _prescriptions.Where(x => x.ConsultationId == consultationId).ToList()
        );
    }

    public Task AddAsync(Prescription prescription)
    {
        prescription.Id = _prescriptions.Count + 1;

        foreach (var item in prescription.Items)
        {
            item.PrescriptionId = prescription.Id;
        }

        _prescriptions.Add(prescription);

        return Task.CompletedTask;
    }
}