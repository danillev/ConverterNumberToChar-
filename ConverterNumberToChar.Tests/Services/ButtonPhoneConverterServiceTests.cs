using ConverterNumberToChar.BLL.Services;
using ConverterNumberToChar.DAL.Interfaces;
using ConverterNumberToChar.DAL.Models;
using ConverterNumberToChar.Tests.TestData;
using Moq;
using Xunit;

public class ButtonPhoneConverterServiceTests
{
    private readonly Mock<IButtonMappingRepository> _mockRepo;
    private readonly ButtonPhoneConverterService _service;

    public ButtonPhoneConverterServiceTests()
    {
        _mockRepo = new Mock<IButtonMappingRepository>();
        _mockRepo.Setup(r => r.GetButtonMappings())
                .Returns(ButtonPhoneTestData.GetDefaultMappings());

        _service = new ButtonPhoneConverterService(_mockRepo.Object);
    }

    [Theory]
    [InlineData("2#", "A")]
    [InlineData("22#", "B")]
    [InlineData("222#", "C")]
    [InlineData("2222#", "A")]
    [InlineData("2233#", "BE")]
    [InlineData("234#", "ADG")]
    public void ConvertToText_ValidInput_ReturnsCorrectOutput(string input, string expected)
    {
        var result = _service.ConvertToText(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData(null, "")]
    public void ConvertToText_EmptyOrNullInput_ReturnsEmptyString(string input, string expected)
    {
        var result = _service.ConvertToText(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ConvertToText_UnknownButton_ReturnsQuestionMark()
    {
        var result = _service.ConvertToText("99#");
        Assert.Equal("?", result);
    }

    [Fact]
    public void ConvertToText_MultipleSequences_HandlesCorrectly()
    {
        var result = _service.ConvertToText("22#33#44#");
        Assert.Equal("BEH", result);
    }

    [Fact]
    public void ConvertToText_WithoutHash_ProcessesLastButton()
    {
        var result = _service.ConvertToText("2233");
        Assert.Equal("BE", result);
    }

    [Fact]
    public void ConvertToText_SpaceButton_WorksCorrectly()
    {
        var result = _service.ConvertToText("0#");
        Assert.Equal(" ", result);
    }
}
