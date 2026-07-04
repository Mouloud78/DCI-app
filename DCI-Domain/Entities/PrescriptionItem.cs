namespace DCI_Domain.Entities;

public class PrescriptionItem
{
    public int Id { get; set; }

    public int PrescriptionId { get; set; }

    public int MedicationId { get; set; }

    public string MedicationName { get; set; } = string.Empty;

    public string Dosage { get; set; } = string.Empty;

    public string Frequency { get; set; } = string.Empty;

    public string Duration { get; set; } = string.Empty;

    public string Instruction { get; set; } = string.Empty;

    public bool IsSubstitutable { get; set; } = true;
}