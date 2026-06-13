using Moq;
using TaskManagement.Application.Abstractions;
using TaskManagement.Application.Tasks.Commands;
using TaskManagement.Domain.Entities;

public class CreateTaskCommandHandlerTests
{
    [Fact]
    public async Task Should_Create_Task_And_Return_Id()
    {
        // Arrange
        var repoMock = new Mock<ITaskRepository>();

        repoMock
            .Setup(x => x.AddAsync(It.IsAny<TaskItem>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        var handler = new CreateTaskCommandHandler(repoMock.Object);

        var command = new CreateTaskCommand("Test task");
        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.NotEqual(Guid.Empty, result);

        repoMock.Verify(x => x.AddAsync(It.IsAny<TaskItem>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}