using MediatR;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Queries;

public record GetTaskByIdQuery(Guid Id) : IRequest<TaskItem?>;