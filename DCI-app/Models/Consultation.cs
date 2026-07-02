namespace DCI_app.Models;

public class Consultation
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int? DoctorId { get; set; }
    public string DoctorName { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;

    public string Symptoms { get; set; } = string.Empty;

    public string ClinicalExam { get; set; } = string.Empty;

    public string Diagnosis { get; set; } = string.Empty;

    public string TreatmentPlan { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;

   
    public ConsultationStatus Status { get; set; } = ConsultationStatus.Open;

}