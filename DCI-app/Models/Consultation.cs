namespace DCI_app.Models;

public class Consultation
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string DoctorName { get; set; } = string.Empty;

    public string Symptoms { get; set; } = string.Empty;

    public string Diagnosis { get; set; } = string.Empty;

    public string Prescription { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;
}