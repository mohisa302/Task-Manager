using Microsoft.EntityFrameworkCore;
using TaskManagement.Application.Abstractions;
using TaskManagement.Domain.Entities;
using TaskManagement.Infrastructure.Persistence;

namespace TaskManagement.Infrastructure.Repositories;

/// <summary>
/// EF Core implementation of Task repository
/// </summary>
public class TaskRepository : ITaskRepository
{
    private readonly AppDbContext _db;

    public TaskRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task AddAsync(TaskItem task, CancellationToken cancellationToken)
    {
        await _db.Tasks.AddAsync(task, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task<TaskItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _db.Tasks.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<TaskItem>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _db.Tasks.ToListAsync(cancellationToken);
    }
}