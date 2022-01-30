using EveEchoesManufacture.Contracts;
using EveEchoesManufacture.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EveEchoesManufacture.ViewModels
{
    public class ManufactureViewModel : BaseViewModel
    {
        public ManufactureViewModel()
        {
            Items.AddRange(man.GetManufacturable().OrderBy(x => x.Name));

            foreach (var t in Items.Select(x => x.Type).Distinct())
            {
                Types.Add(t);
            }

            var m = settings.GetSetting(SettingsKey.resourceCosts) as string ?? string.Empty;
            if (string.IsNullOrEmpty(m))
            {
                settings.SetKey(SettingsKey.resourceCosts, JsonConvert.SerializeObject(ResourceValues));
            }
            else
                ResourceValues = JsonConvert.DeserializeObject<ResourceValues>(m);


            var e = settings.GetSetting(SettingsKey.efficiencies) as string ?? string.Empty;
            if (string.IsNullOrEmpty(e))
            {
                settings.SetKey(SettingsKey.efficiencies, JsonConvert.SerializeObject(Efficiencies));
            }
            else
                Efficiencies = JsonConvert.DeserializeObject<MaterialEfficiencies>(e);
        }

        public MaterialEfficiencies Efficiencies { get; set; }


        private BaseManufacturablesService man = new BaseManufacturablesService();
        private CostCalculatorService costCalculator = new CostCalculatorService();
        

        internal void EffiencyChanged()
        {
            item.UpdateEffectiveEfficiencies(GetEfficiency());
        }

        public string GetEfficiency()
        {
            switch (SelectedItem.Type)
            {
                case "Frigate":
                    return Efficiencies.FrigateEfficiency;
                case "Destroyer":
                    return Efficiencies.DestroyerEfficiency;
                case "Cruiser":
                    return Efficiencies.CruiserEfficiency;
                case "Battlecruiser":
                    return Efficiencies.BattleCruiserEfficiency;
                case "Battleship":
                    return Efficiencies.BattleshipEfficiency;
                case "Drone":
                    return Efficiencies.DroneEfficiency;
                case "Rig":
                    return Efficiencies.RigEfficiency;
                case "Structure":
                    return Efficiencies.StructureEfficiency;
                case "Industrial":
                    return Efficiencies.IndustrialEfficiency;
                default: return "0";
            };
        }

        public ObservableCollection<string> Types { get; set; } = new ObservableCollection<string>();
        public string SelectedType { get; set; } = string.Empty;
        public ObservableCollection<string> MatchingTypeOptions { get; set; } = new ObservableCollection<string>();
        public string MatchingTypeOption { get; set; } = string.Empty;
        public List<ManufacturableItem> Items { get; set; } = new List<ManufacturableItem>();
        public ResourceValues ResourceValues { get; set; } = new ResourceValues();

        private ManufacturableItem item = new ManufacturableItem();

        public float MaterialCost { get; set; }
        public float TotalManufactureCost { get; set; }
        public string DisplayMaterialCost { get; set; }
        public string DisplayTotalManufactureCost { get; set; }

        public string EstimatedBrokerage { get; set; }
        public string EstimatedTax { get; set; }

        public ManufacturableItem SelectedItem
        {
            get { return item; }
            set
            {
                item = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        
 
        private MaterialEfficiencies efficiencies = new MaterialEfficiencies();

        internal void SaveUpdate()
        {
            settings.SetKey(SettingsKey.resourceCosts, JsonConvert.SerializeObject(ResourceValues));
            settings.SetKey(SettingsKey.efficiencies, JsonConvert.SerializeObject(Efficiencies));
            UpdateCosts();
        }

        internal void ItemTypePopulate(string selectedItem)
        {
            MatchingTypeOptions.Clear();
            foreach (var t in Items.Where(x => x.Type == selectedItem).Select(x => x.Name))
                MatchingTypeOptions.Add(t);
        }

        internal void ItemSelected(string selectedItem)
        {
            SelectedItem = Items.FirstOrDefault(x => x.Name == selectedItem);
            UpdateCosts();
        }

        private void UpdateCosts()
        {
            if (SelectedItem != null)
            {
                MaterialCost = costCalculator.CalculateCost(SelectedItem, ResourceValues, GetEfficiency());
                TotalManufactureCost = float.Parse(SelectedItem.ProductionCost) + MaterialCost;

                DisplayMaterialCost = String.Format("{0:#,0.00}", (Int64)MaterialCost);
                DisplayTotalManufactureCost = String.Format("{0:#,0.00}", (Int64)TotalManufactureCost);

                EstimatedBrokerage = String.Format("{0:#,0.00}", float.Parse(Efficiencies.BrokerRate.Replace("%", "")) * TotalManufactureCost * 0.01f);
                EstimatedTax = String.Format("{0:#,0.00}", float.Parse(Efficiencies.TaxRate.Replace("%", "")) * TotalManufactureCost * 0.01f);
                EffiencyChanged();
            }
        }
    }
}
