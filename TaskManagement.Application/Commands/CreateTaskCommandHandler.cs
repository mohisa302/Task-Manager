using MediatR;
using TaskManagement.Application.Abstractions;
using TaskManagement.Application.Tasks.Commands;
using TaskManagement.Domain.Entities;

public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
{
    private readonly ITaskRepository _repo;

    public CreateTaskCommandHandler(ITaskRepository repo)
    {
        _repo = repo;
    }

    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = new TaskItem(request.Title);

        await _repo.AddAsync(task, cancellationToken);

        return task.Id;
    }
}