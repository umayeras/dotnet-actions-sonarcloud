using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApp.API.Controllers;

namespace WebApp.Tests.API.Controllers;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class SamplesControllerTests
{
    [SetUp]
    public void Init()
    {
        controller = new SamplesController();
    }

    private SamplesController controller = null!;

    [Test]
    public void Get_NoCondition_ReturnOkResult()
    {
        // Arrange & Act
        var result = controller.Get();

        // Assert
        result.Should().BeOfType<OkResult>();
    }
}