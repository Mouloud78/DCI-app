namespace DCI_app.Models;

public class Prescription
{
    public int Id { get; set; }

    public int ConsultationId { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string Notes { get; set; } = string.Empty;

    public List<PrescriptionItem> Items { get; set; } = new();
}