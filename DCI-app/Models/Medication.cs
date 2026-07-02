namespace DCI_app.Models;

public class Medication
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Form { get; set; } = string.Empty; 

    public string DosageUnit { get; set; } = "mg";
}