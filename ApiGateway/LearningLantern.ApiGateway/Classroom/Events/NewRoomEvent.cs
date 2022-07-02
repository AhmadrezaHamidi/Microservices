using LearningLantern.ApiGateway.Classroom.Repositories;
using LearningLantern.Common.Extensions;
using LearningLantern.EventBus.Events;

namespace LearningLantern.ApiGateway.Classroom.Events;

public class NewRoomEvent : IntegrationEvent
{
    public string ClassId { get; set; } = null!;
    public string UserId { get; set; } = null!;
}

public class NewRoomEventHandler : IIntegrationEventHandler<NewRoomEvent>
{
    private readonly IClassroomRepository _classroomRepository;
    private readonly ILogger<NewRoomEventHandler> _logger;

    public NewRoomEventHandler(ILogger<NewRoomEventHandler> logger, IClassroomRepository classroomRepository)
    {
        _logger = logger;
        _classroomRepository = classroomRepository;
    }

    public Task Handle(NewRoomEvent @event)
    {
        _logger.LogInformation("NewRoomEventHandler = " + @event.ToJsonStringContent());
        return Task.CompletedTask;
    }
}