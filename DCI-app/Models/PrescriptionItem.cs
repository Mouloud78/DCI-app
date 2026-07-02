namespace DCI_app.Models;

public class PrescriptionItem
{
    public int Id { get; set; }

    public int PrescriptionId { get; set; }

    public int MedicationId { get; set; }

    public string MedicationName { get; set; } = string.Empty;

    public string Dosage { get; set; } = string.Empty; 

    public string Frequency { get; set; } = string.Empty; 

    public string Duration { get; set; } = string.Empty; 
}