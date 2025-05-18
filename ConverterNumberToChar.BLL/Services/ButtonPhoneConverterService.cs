using ConverterNumberToChar.DAL.Interfaces;
using ConverterNumberToChar.DAL.Models;
using System.Text;

namespace ConverterNumberToChar.BLL.Services;

public class ButtonPhoneConverterService
{

    private readonly List<ButtonMapping> _mappings;

    public ButtonPhoneConverterService(IButtonMappingRepository provider)
    {
        _mappings = provider.GetButtonMappings();
    }

    public string ConvertToText(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new StringBuilder();
        int currentButton = -1;
        int pressCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c == '#')
            {
                if (currentButton != -1)
                {
                    result.Append(GetCharacter(currentButton, pressCount));
                    currentButton = -1;
                    pressCount = 0;
                }
                continue;
            }

            int buttonNumber = c - '0'; 

            if (buttonNumber == currentButton)
            {
                pressCount++;
            }
            else
            {
                if (currentButton != -1)
                {
                    result.Append(GetCharacter(currentButton, pressCount));
                }
                currentButton = buttonNumber;
                pressCount = 1;
            }
        }
        
        if (currentButton != -1)
        {
            result.Append(GetCharacter(currentButton, pressCount));
        }

        return result.ToString();
    }

    private char GetCharacter(int buttonNumber, int pressCount)
    {
        var mapping = _mappings.FirstOrDefault(b => b.ButtonNumber == buttonNumber);
        if (mapping == null)
            return '?';
        
        int index = (pressCount - 1) % mapping.Characters.Length;
        return mapping.Characters[index];
    }
}