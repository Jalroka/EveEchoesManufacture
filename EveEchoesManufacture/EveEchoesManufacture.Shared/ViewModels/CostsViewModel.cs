using EveEchoesManufacture.Contracts;
using EveEchoesManufacture.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveEchoesManufacture.ViewModels
{
    public class CostsViewModel : BaseViewModel
    {
        public CostsViewModel()
        {
            var m = settings.GetSetting(SettingsKey.resourceCosts) as string ?? string.Empty;
            if (string.IsNullOrEmpty(m))
            {
                settings.SetKey(SettingsKey.resourceCosts, JsonConvert.SerializeObject(ResourceValues));
            }
            else
                ResourceValues = JsonConvert.DeserializeObject<ResourceValues>(m);
        }

        public ResourceValues ResourceValues { get; set; } = new ResourceValues();
        internal void SaveUpdate()
        {
            settings.SetKey(SettingsKey.resourceCosts, JsonConvert.SerializeObject(ResourceValues));
            //settings.SetKey(SettingsKey.efficiencies, JsonConvert.SerializeObject(Efficiencies));
            //UpdateCosts();
        }
    }
}
