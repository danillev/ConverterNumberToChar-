using ConverterNumberToChar.DAL.Interfaces;
using ConverterNumberToChar.DAL.Models;

namespace ConverterNumberToChar.DAL.Repositories;

public class MemoryButtonMappingRepository : IButtonMappingRepository
{
    public List<ButtonMapping> GetButtonMappings()
    {
        return new List<ButtonMapping>
        {
            new ButtonMapping { ButtonNumber = 2, Characters = new[] { 'A', 'B', 'C' } },
            new ButtonMapping { ButtonNumber = 3, Characters = new[] { 'D', 'E', 'F' } },
            new ButtonMapping { ButtonNumber = 4, Characters = new[] { 'G', 'H', 'I' } },
            new ButtonMapping { ButtonNumber = 5, Characters = new[] { 'J', 'K', 'L' } },
            new ButtonMapping { ButtonNumber = 6, Characters = new[] { 'M', 'N', 'O' } },
            new ButtonMapping { ButtonNumber = 7, Characters = new[] { 'P', 'Q', 'R', 'S' } },
            new ButtonMapping { ButtonNumber = 8, Characters = new[] { 'T', 'U', 'V' } },
            new ButtonMapping { ButtonNumber = 9, Characters = new[] { 'W', 'X', 'Y', 'Z' } },
            new ButtonMapping { ButtonNumber = 0, Characters = new[] { ' ' } }
        };
    }
}