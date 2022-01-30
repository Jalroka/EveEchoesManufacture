using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Windows.Storage;

namespace EveEchoesManufacture.Services
{
    public class SettingsServices
    {
        public object GetSetting(SettingsKey key)
        {
            var setting = ApplicationData.Current.LocalSettings.Values[key.ToString()];
            if (setting != null)
                Debug.WriteLine(setting.ToString());
            return setting;
        }

        public void SetKey(SettingsKey key, object value)
        {
            Debug.WriteLine($"Setting Set {key} {value}");
            ApplicationData.Current.LocalSettings.Values[key.ToString()] = value;
        }
    }

    public enum SettingsKey
    {
        resourceCosts,
        efficiencies,
        marketcosts,
    }
}
