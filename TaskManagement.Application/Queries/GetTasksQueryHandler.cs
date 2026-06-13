using MediatR;
using TaskManagement.Application.Abstractions;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Queries;

public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, List<TaskItem>>
{
    private readonly ITaskRepository _repo;

    public GetTasksQueryHandler(ITaskRepository repo)
    {
        _repo = repo;
    }

    public Task<List<TaskItem>> Handle(GetTasksQuery request, CancellationToken ct)
    {
        return _repo.GetAllAsync(ct);
    }
}