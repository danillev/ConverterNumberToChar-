using ConverterNumberToChar.DAL.Models;

namespace ConverterNumberToChar.DAL.Interfaces;

public interface IButtonMappingRepository
{
    List<ButtonMapping> GetButtonMappings();
}