using QuestPDF.Fluent;
using DCI_Infrastructure.Pdf;
using DCI_Domain.Entities;
using DCI_Domain.Enums;

public class PrescriptionPdfService
{
    public byte[] Generate(Prescription prescription, Patient patient)
    {
        var doc = new PrescriptionPdfDocument(prescription, patient);
        return doc.GeneratePdf();
    }
}