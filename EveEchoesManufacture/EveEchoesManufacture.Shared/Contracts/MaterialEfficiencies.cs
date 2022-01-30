using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EveEchoesManufacture.Contracts
{
    public class MaterialEfficiencies : BaseObservable
    {
        public string FrigateEfficiency { get; set; } = "150%";
        public string CruiserEfficiency { get; set; } = "150%";
        public string DestroyerEfficiency { get; set; } = "150%";
        public string BattleCruiserEfficiency { get; set; } = "150%";
        public string BattleshipEfficiency { get; set; } = "150%";
        public string IndustrialEfficiency { get; set; } = "150%";
        public string ModuleEfficiency { get; set; } = "150%";
        public string RigEfficiency { get; set; } = "150%";
        public string DroneEfficiency { get; set; } = "150%";
        public string StructureEfficiency { get; set; } = "150%";

        public string BrokerRate { get; set; } = "8.0%";
        public string TaxRate { get; set; } = "15%";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
