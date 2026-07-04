using DCI_Domain.Enums;

namespace DCI_Domain.Entities;

public class Prescription
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int ConsultationId { get; set; }

    public int DoctorId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public string Notes { get; set; } = string.Empty;

    public PrescriptionStatus Status { get; set; } = PrescriptionStatus.Active;

    public List<PrescriptionItem> Items { get; set; } = new();
}