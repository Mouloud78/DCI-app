using DCI_app.Models;

namespace DCI_app.Services;

public class PatientService
{
    private readonly List<Patient> _patients = new();

    public PatientService()
    {
        _patients.Add(new Patient
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Phone = "123456789",
            Address = "Québec"
        });

        _patients.Add(new Patient
        {
            Id = 2,
            FirstName = "Marie",
            LastName = "Curie",
            Phone = "987654321",
            Address = "Montreal"
        });
    }

    public Task<List<Patient>> GetAllAsync()
        => Task.FromResult(_patients);

    public Task AddAsync(Patient patient)
    {
        patient.Id = _patients.Count == 0 ? 1 : _patients.Max(p => p.Id) + 1;
        _patients.Add(patient);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == id);
        if (patient != null)
            _patients.Remove(patient);

        return Task.CompletedTask;
    }

    public Task<List<Patient>> SearchAsync(string search)
    {
        var result = _patients
            .Where(p =>
                p.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                p.LastName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                p.Phone.Contains(search))
            .ToList();

        return Task.FromResult(result);
    }

    public Task<Patient?> GetByIdAsync(int id)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(patient);
    }
}