using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EveEchoesManufacture.Contracts
{
    public class ResourceValues : INotifyPropertyChanged
    {
        public float Tritanium { get; set; }
        public float Pyerite { get; set; }
        public float Mexallon { get; set; }
        public float Isogen { get; set; }
        public float Nocxium { get; set; }
        public float Zydrine { get; set; }
        public float Megacyte { get; set; }
        public float Morphite { get; set; }
        public float LusteringAlloy { get; set; }
        public float SheenCompound { get; set; }
        public float GleamingAlloy { get; set; }
        public float CondensedAlloy { get; set; }
        public float PreciousAlloy { get; set; }
        public float MotleyCompound { get; set; }
        public float FiberComposite { get; set; }
        public float LucentCompound { get; set; }
        public float OpulentCompound { get; set; }
        public float GlossyCompound { get; set; }
        public float CrystalCompound { get; set; }
        public float DarkCompound { get; set; }
        public float BaseMetals { get; set; }
        public float HeavyMetals { get; set; }
        public float ReactiveMetals { get; set; }
        public float NobleMetals { get; set; }
        public float ToxicMetals { get; set; }
        public float ReactiveGas { get; set; }
        public float NobleGas { get; set; }
        public float IndustrialFibers { get; set; }
        public float SupertensilePlastics { get; set; }
        public float Polyaramids { get; set; }
        public float Coolant { get; set; }
        public float Condensates { get; set; }
        public float ConstructionBlocks { get; set; }
        public float Nanites { get; set; }
        public float SilicateGlass { get; set; }
        public float SmartfabUnits { get; set; }
        public float CharredMicroCircuit { get; set; }
        public float FriedInterfaceCircuit { get; set; }
        public float TrippedPowerCircuit { get; set; }
        public float SmashedTriggerUnit { get; set; }
        public float DamagedCloseinWeaponSystem { get; set; }
        public float ScorchedTelemetryProcessor { get; set; }
        public float ContaminatedLorentzFluid { get; set; }
        public float ConductivePolymer { get; set; }
        public float ContaminatedNaniteCompound { get; set; }
        public float DefectiveCurrentPump { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
