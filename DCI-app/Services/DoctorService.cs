using DCI_app.Models;

namespace DCI_app.Services;

public class DoctorService
{
    private readonly List<Doctor> _doctors = new();

    public DoctorService()
    {
        _doctors.Add(new Doctor
        {
            Id = 1,
            FirstName = "Ahmed",
            LastName = "Benali",
            Specialty = "Cardiologie",
            Phone = "0600000001",
            Email = "ahmed@clinic.com"
        });

        _doctors.Add(new Doctor
        {
            Id = 2,
            FirstName = "Sarah",
            LastName = "Martin",
            Specialty = "Pédiatrie",
            Phone = "0600000002",
            Email = "sarah@clinic.com"
        });
    }

    public Task<List<Doctor>> GetAllAsync()
        => Task.FromResult(_doctors);

    public Task<Doctor?> GetByIdAsync(int id)
    {
        var doctor = _doctors.FirstOrDefault(d => d.Id == id);
        return Task.FromResult(doctor);
    }

    public Task AddAsync(Doctor doctor)
    {
        doctor.Id = _doctors.Count == 0 ? 1 : _doctors.Max(d => d.Id) + 1;
        _doctors.Add(doctor);
        return Task.CompletedTask;
    }
}