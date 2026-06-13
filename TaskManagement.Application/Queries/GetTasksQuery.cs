using MediatR;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Queries;

public record GetTasksQuery() : IRequest<List<TaskItem>>;