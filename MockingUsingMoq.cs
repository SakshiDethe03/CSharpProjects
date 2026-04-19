using Moq;

var mock = new Mock<IService>();
mock.Setup(x => x.Run());

mock.Object.Run();