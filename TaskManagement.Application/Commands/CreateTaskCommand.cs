using MediatR;

namespace TaskManagement.Application.Tasks.Commands;

/// <summary>
/// Command to create a new task
/// </summary>
public record CreateTaskCommand(string Title) : IRequest<Guid>;