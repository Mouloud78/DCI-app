namespace DCI_Domain.Entities;

public class MedicalHistory
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string Diagnosis { get; set; } = string.Empty;

    public string Treatment { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;
}