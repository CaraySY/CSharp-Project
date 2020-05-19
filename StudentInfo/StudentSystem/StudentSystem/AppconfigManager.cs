using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StudentSystem
{
    public class AppconfigManager
    {
        public static bool WriteConfigValue(string newKey, string newValue)
        {
            try
            {
                bool isModified = false;
                foreach (string key in ConfigurationManager.AppSettings)
                {
                    if (key == newKey)
                    {
                        isModified = true;
                    }
                }
                // Open App.Config of executable
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // You need to remove the old settings object before you can replace it
                if (isModified)
                {
                    config.AppSettings.Settings.Remove(newKey);
                }
                // Add an Application Setting.
                config.AppSettings.Settings.Add(newKey, newValue);
                // Save the changes in App.config file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GetConfigValue(string key)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.AppSettings.Settings[key] == null)
                {
                    LogInfo.WriteLog($"GetConfigValue 【{key}】 is null");
                    return "";
                }
                else
                {
                    return config.AppSettings.Settings[key].Value;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
