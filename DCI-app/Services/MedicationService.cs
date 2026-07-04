using Microsoft.EntityFrameworkCore;
using DCI_Domain.Entities;
using DCI_Infrastructure.Data;

namespace DCI_app.Services;

public class MedicationService
{
    private readonly ApplicationDbContext _context;

    public MedicationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Medication>> GetAllAsync()
    {
        return await _context.Medications
            .OrderBy(x => x.Name)
            .ToListAsync();
    }

    public async Task<Medication?> GetByIdAsync(int id)
    {
        return await _context.Medications.FindAsync(id);
    }

    public async Task AddAsync(Medication medication)
    {
        _context.Medications.Add(medication);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Medication medication)
    {
        _context.Medications.Update(medication);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var medication = await _context.Medications.FindAsync(id);

        if (medication is null)
            return;

        _context.Medications.Remove(medication);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Medication>> SearchAsync(string search)
    {
        return await _context.Medications
            .Where(x =>
                x.Name.Contains(search) ||
                x.GenericName.Contains(search))
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}