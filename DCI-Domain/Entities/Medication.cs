namespace DCI_Domain.Entities;

public class Medication
{
    public int Id { get; set; }

    // Nom commercial
    public string Name { get; set; } = string.Empty;

    // Principe actif
    public string GenericName { get; set; } = string.Empty;

    // Dosage (500 mg, 1 g, etc.)
    public string Strength { get; set; } = string.Empty;

    // Comprimé, Gélule, Sirop...
    public string Form { get; set; } = string.Empty;

    // Voie d'administration
    // Orale, IV, IM, Cutanée...
    public string Route { get; set; } = string.Empty;

    // Fabricant
    public string Manufacturer { get; set; } = string.Empty;

    // Code interne ou CIP
    public string Code { get; set; } = string.Empty;

    // Disponible à la pharmacie
    public bool IsAvailable { get; set; } = true;
}