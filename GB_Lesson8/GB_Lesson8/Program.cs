using System;
using System.Configuration;

namespace GB_Lesson8
{
    class Program
    {
        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? $"Parameter {key} not found";
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void UpdateSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }

        }
        static void Main(string[] args)
        {
            ReadSetting("Title");
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = Console.ReadLine();
            Console.Write("Введите ваше сферу деятельности: ");
            var occupation = Console.ReadLine();

            UpdateSettings("Title", $"Hello, {name}");
            UpdateSettings("Name", name);
            UpdateSettings("Age", age);
            UpdateSettings("Occupation", occupation);
        }
    }
}
