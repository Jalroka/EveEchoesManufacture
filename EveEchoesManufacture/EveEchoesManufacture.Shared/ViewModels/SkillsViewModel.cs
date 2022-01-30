using EveEchoesManufacture.Contracts;
using EveEchoesManufacture.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveEchoesManufacture.ViewModels
{
    public class SkillsViewModel : BaseViewModel
    {
        public SkillsViewModel()
        {
            var e = settings.GetSetting(SettingsKey.efficiencies) as string ?? string.Empty;
            if (string.IsNullOrEmpty(e))
            {
                settings.SetKey(SettingsKey.efficiencies, JsonConvert.SerializeObject(Efficiencies));
            }
            else
                Efficiencies = JsonConvert.DeserializeObject<MaterialEfficiencies>(e);
        }

        public MaterialEfficiencies Efficiencies { get; set; }

        public List<string> MaterialEfficiencyOptions = new List<string>()
        {
            "150%",
            "144%",
            "138%",
            "132%",
            "126%",
            "122%",
            "120%",
            "118%",
            "116%",
            "114%",
            "112%",
            "110%",
            "108%",
            "106%",
            "104%",
            "100%",
            "99%",
            "98%",
            "97%",
            "96%",
            "95%",
        };

        public List<string> MarketBrokersFeesOptions = new List<string>()
        {
            "8.0%",
            "7.8%",
            "7.6%",
            "7.4%",
            "7.2%",
            "7.0%",
            "6.8%",
            "6.6%",
            "6.4%",
            "6.2%",
            "6.0%",
            "5.8%",
            "5.6%",
            "5.4%",
            "5.2%",
            "5.0%",
        };


        public List<string> MarketTaxesOptions = new List<string>()
        {
            "15%",
            "14%",
            "13%",
            "12%",
            "11%",
            "10%",
        };

        internal void EffiencyChanged()
        {
            SaveUpdate();
            //item.UpdateEffectiveEfficiencies(GetEfficiency());
        }

        internal void SaveUpdate()
        {
            //settings.SetKey(SettingsKey.resourceCosts, JsonConvert.SerializeObject(ResourceValues));
            settings.SetKey(SettingsKey.efficiencies, JsonConvert.SerializeObject(Efficiencies));
            //UpdateCosts();
        }

        //public string GetEfficiency()
        //{
        //    switch (SelectedItem.Type)
        //    {
        //        case "Frigate":
        //            return Efficiencies.FrigateEfficiency;
        //        case "Destroyer":
        //            return Efficiencies.DestroyerEfficiency;
        //        case "Cruiser":
        //            return Efficiencies.CruiserEfficiency;
        //        case "Battlecruiser":
        //            return Efficiencies.BattleCruiserEfficiency;
        //        case "Battleship":
        //            return Efficiencies.BattleshipEfficiency;
        //        case "Drone":
        //            return Efficiencies.DroneEfficiency;
        //        case "Rig":
        //            return Efficiencies.RigEfficiency;
        //        case "Structure":
        //            return Efficiencies.StructureEfficiency;
        //        case "Industrial":
        //            return Efficiencies.IndustrialEfficiency;
        //        default: return "0";
        //    };
        //}
    }
}
