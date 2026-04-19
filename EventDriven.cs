// publish
await bus.Publish(new StudentCreated());

// handle
public class Handler : IConsumer<StudentCreated> { }