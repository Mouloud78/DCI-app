


using DCI_Domain.Entities;
using DCI_Domain.Enums;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace DCI_Infrastructure.Pdf;

public class PrescriptionPdfDocument : IDocument
{
    private readonly Prescription _prescription;
    private readonly Patient _patient;

    public PrescriptionPdfDocument(Prescription prescription, Patient patient)
    {
        _prescription = prescription;
        _patient = patient;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(30);

            page.Header()
                .Text("🏥 HÔPITAL DCI - ORDONNANCE")
                .SemiBold().FontSize(18);

            page.Content()
                .Column(col =>
                {
                    col.Item().Text($"Patient : {_patient.FirstName} {_patient.LastName}");
                    col.Item().Text($"Date : {_prescription.CreatedAt:dd/MM/yyyy}");

                    col.Item().PaddingTop(10).Text("Prescriptions :").Bold();

                    foreach (var item in _prescription.Items)
                    {
                        col.Item().Text(
                            $"- {item.MedicationName} {item.Dosage} : {item.Frequency} - {item.Duration}"
                        );
                    }
                });

            page.Footer()
                .AlignCenter()
                .Text(x =>
                {
                    x.Span("DCI System - Confidential");
                });
        });
    }
}