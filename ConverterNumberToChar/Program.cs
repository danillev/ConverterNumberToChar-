using ConverterNumberToChar.BLL.Services;
using ConverterNumberToChar.DAL.Interfaces;
using ConverterNumberToChar.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConverterNumberToChar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection()
                .AddSingleton<IButtonMappingRepository, MemoryButtonMappingRepository>()
                .AddSingleton<ButtonPhoneConverterService>()
                .BuildServiceProvider();

            var converter = services.GetRequiredService<ButtonPhoneConverterService>();
            Application.Run(new MainForm(converter));
        }
    }
}