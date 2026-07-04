using DCI_Domain.Entities;
using DCI_Domain.Enums;

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

    public Task UpdateAsync(Consultation consultation)
    {
        var existing = _consultations.FirstOrDefault(c => c.Id == consultation.Id);

        if (existing != null)
        {
            existing.DoctorName = consultation.DoctorName;
            existing.Symptoms = consultation.Symptoms;
            existing.ClinicalExam = consultation.ClinicalExam;
            existing.Diagnosis = consultation.Diagnosis;
            existing.TreatmentPlan = consultation.TreatmentPlan;
            existing.Notes = consultation.Notes;
            existing.Status = consultation.Status;
        }

        return Task.CompletedTask;
    }

    public Task CloseAsync(int id)
    {
        var consultation = _consultations.FirstOrDefault(c => c.Id == id);

        if (consultation != null)
            consultation.Status = ConsultationStatus.Closed;

        return Task.CompletedTask;
    }
}