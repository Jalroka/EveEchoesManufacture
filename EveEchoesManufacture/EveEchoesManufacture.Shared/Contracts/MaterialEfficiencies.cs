using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EveEchoesManufacture.Contracts
{
    public class MaterialEfficiencies : BaseObservable
    {
        private const string defaultValue = "150%";
        public string FrigateEfficiency { get; set; } = defaultValue;
        public string CruiserEfficiency { get; set; } = defaultValue;
        public string DestroyerEfficiency { get; set; } = defaultValue;
        public string BattleCruiserEfficiency { get; set; } = defaultValue;
        public string BattleshipEfficiency { get; set; } = defaultValue;
        public string IndustrialEfficiency { get; set; } = defaultValue;
        public string ModuleEfficiency { get; set; } = defaultValue;
        public string RigEfficiency { get; set; } = defaultValue;
        public string DroneEfficiency { get; set; } = defaultValue;
        public string StructureEfficiency { get; set; } = defaultValue;

        public string BrokerRate { get; set; } = "8.0%";
        public string TaxRate { get; set; } = "15%";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
