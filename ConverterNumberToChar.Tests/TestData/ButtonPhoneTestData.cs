using ConverterNumberToChar.DAL.Models;

namespace ConverterNumberToChar.Tests.TestData;

public static class ButtonPhoneTestData
{
    public static List<ButtonMapping> GetDefaultMappings() => new()
    {
        new ButtonMapping { ButtonNumber = 2, Characters = new[] { 'A', 'B', 'C' } },
        new ButtonMapping { ButtonNumber = 3, Characters = new[] { 'D', 'E', 'F' } },
        new ButtonMapping { ButtonNumber = 4, Characters = new[] { 'G', 'H', 'I' } },
        new ButtonMapping { ButtonNumber = 0, Characters = new[] { ' ' } }
    };
}