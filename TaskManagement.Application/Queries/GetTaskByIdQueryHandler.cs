using MediatR;
using TaskManagement.Application.Abstractions;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Queries;

public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskItem?>
{
    private readonly ITaskRepository _repo;

    public GetTaskByIdQueryHandler(ITaskRepository repo)
    {
        _repo = repo;
    }

    public Task<TaskItem?> Handle(GetTaskByIdQuery request, CancellationToken ct)
    {
        return _repo.GetByIdAsync(request.Id, ct);
    }
}