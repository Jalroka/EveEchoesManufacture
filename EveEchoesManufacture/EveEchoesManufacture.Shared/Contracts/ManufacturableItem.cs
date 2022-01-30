using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EveEchoesManufacture.Contracts
{
    public class ManufacturableItem : BaseObservable
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string TechLevel { get; set; } = "0";


        public string Tritanium { get; set; } = "0";
        public string Pyerite { get; set; } = "0";
        public string Mexallon { get; set; } = "0";
        public string Isogen { get; set; } = "0";
        public string Nocxium { get; set; } = "0";
        public string Zydrine { get; set; } = "0";
        public string Megacyte { get; set; } = "0";
        public string Morphite { get; set; } = "0";
        public string LusteringAlloy { get; set; } = "0";
        public string SheenCompound { get; set; } = "0";
        public string GleamingAlloy { get; set; } = "0";
        public string CondensedAlloy { get; set; } = "0";
        public string PreciousAlloy { get; set; } = "0";
        public string MotleyCompound { get; set; } = "0";
        public string FiberComposite { get; set; } = "0";
        public string LucentCompound { get; set; } = "0";
        public string OpulentCompound { get; set; } = "0";
        public string GlossyCompound { get; set; } = "0";
        public string CrystalCompound { get; set; } = "0";
        public string DarkCompound { get; set; } = "0";
        public string BaseMetals { get; set; } = "0";
        public string HeavyMetals { get; set; } = "0";
        public string ReactiveMetals { get; set; } = "0";
        public string NobleMetals { get; set; } = "0";
        public string ToxicMetals { get; set; } = "0";
        public string ReactiveGas { get; set; } = "0";
        public string NobleGas { get; set; } = "0";
        public string IndustrialFibers { get; set; } = "0";
        public string SupertensilePlastics { get; set; } = "0";
        public string Polyaramids { get; set; } = "0";
        public string Coolant { get; set; } = "0";
        public string Condensates { get; set; } = "0";
        public string ConstructionBlocks { get; set; } = "0";
        public string Nanites { get; set; } = "0";
        public string SilicateGlass { get; set; } = "0";
        public string SmartfabUnits { get; set; } = "0";
        public string CharredMicroCircuit { get; set; } = "0";
        public string FriedInterfaceCircuit { get; set; } = "0";
        public string TrippedPowerCircuit { get; set; } = "0";
        public string SmashedTriggerUnit { get; set; } = "0";
        public string DamagedCloseinWeaponSystem { get; set; } = "0";
        public string ScorchedTelemetryProcessor { get; set; } = "0";
        public string ContaminatedLorentzFluid { get; set; } = "0";
        public string ConductivePolymer { get; set; } = "0";
        public string ContaminatedNaniteCompound { get; set; } = "0";
        //public string ContaminatedNaniteCompound { get; set; } = "0";
        public string DefectiveCurrentPump { get; set; } = "0";


        public string ProductionCost { get; set; } = "0";
        public string ProductionTime { get; set; } = "0";
        public string ProductionCount { get; set; } = "0";

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateEffectiveEfficiencies(string efficiency)
        {
            float e = float.Parse(efficiency.Replace("%", "")) * .01f;

            EffectiveTritanium = String.Format("{0:#,0.00}", float.Parse(Tritanium) * e);
            EffectivePyerite = String.Format("{0:#,0.00}", float.Parse(Pyerite) * e);
            EffectiveMexallon = String.Format("{0:#,0.00}", float.Parse(Mexallon) * e);
            EffectiveIsogen = String.Format("{0:#,0.00}", float.Parse(Isogen) * e);
            EffectiveNocxium = String.Format("{0:#,0.00}", float.Parse(Nocxium) * e);
            EffectiveZydrine = String.Format("{0:#,0.00}", float.Parse(Zydrine) * e);
            EffectiveMegacyte = String.Format("{0:#,0.00}", float.Parse(Megacyte) * e);
            EffectiveMorphite = String.Format("{0:#,0.00}", float.Parse(Morphite) * e);
            EffectiveLusteringAlloy = String.Format("{0:#,0.00}", float.Parse(LusteringAlloy) * e);
            EffectiveSheenCompound = String.Format("{0:#,0.00}", float.Parse(SheenCompound) * e);
            EffectiveGleamingAlloy = String.Format("{0:#,0.00}", float.Parse(GleamingAlloy) * e);
            EffectiveCondensedAlloy = String.Format("{0:#,0.00}", float.Parse(CondensedAlloy) * e);
            EffectivePreciousAlloy = String.Format("{0:#,0.00}", float.Parse(PreciousAlloy) * e);
            EffectiveMotleyCompound = String.Format("{0:#,0.00}", float.Parse(MotleyCompound) * e);
            EffectiveFiberComposite = String.Format("{0:#,0.00}", float.Parse(FiberComposite) * e);
            EffectiveLucentCompound = String.Format("{0:#,0.00}", float.Parse(LucentCompound) * e);
            EffectiveOpulentCompound = String.Format("{0:#,0.00}", float.Parse(OpulentCompound) * e);
            EffectiveGlossyCompound = String.Format("{0:#,0.00}", float.Parse(GlossyCompound) * e);
            EffectiveCrystalCompound = String.Format("{0:#,0.00}", float.Parse(CrystalCompound) * e);
            EffectiveDarkCompound = String.Format("{0:#,0.00}", float.Parse(DarkCompound) * e);
            EffectiveBaseMetals = String.Format("{0:#,0.00}", float.Parse(BaseMetals) * e);
            EffectiveHeavyMetals = String.Format("{0:#,0.00}", float.Parse(HeavyMetals) * e);
            EffectiveReactiveMetals = String.Format("{0:#,0.00}", float.Parse(ReactiveMetals) * e);
            EffectiveNobleMetals = String.Format("{0:#,0.00}", float.Parse(NobleMetals) * e);
            EffectiveToxicMetals = String.Format("{0:#,0.00}", float.Parse(ToxicMetals) * e);
            EffectiveReactiveGas = String.Format("{0:#,0.00}", float.Parse(ReactiveGas) * e);
            EffectiveNobleGas = String.Format("{0:#,0.00}", float.Parse(NobleGas) * e);
            EffectiveIndustrialFibers = String.Format("{0:#,0.00}", float.Parse(IndustrialFibers) * e);
            EffectiveSupertensilePlastics = String.Format("{0:#,0.00}", float.Parse(SupertensilePlastics) * e);
            EffectivePolyaramids = String.Format("{0:#,0.00}", float.Parse(Polyaramids) * e);
            EffectiveCoolant = String.Format("{0:#,0.00}", float.Parse(Coolant) * e);
            EffectiveCondensates = String.Format("{0:#,0.00}", float.Parse(Condensates) * e);
            EffectiveConstructionBlocks = String.Format("{0:#,0.00}", float.Parse(ConstructionBlocks) * e);
            EffectiveNanites = String.Format("{0:#,0.00}", float.Parse(Nanites) * e);
            EffectiveSilicateGlass = String.Format("{0:#,0.00}", float.Parse(SilicateGlass) * e);
            EffectiveSmartfabUnits = String.Format("{0:#,0.00}", float.Parse(SmartfabUnits) * e);
            EffectiveCharredMicroCircuit = String.Format("{0:#,0.00}", float.Parse(CharredMicroCircuit) * e);
            EffectiveFriedInterfaceCircuit = String.Format("{0:#,0.00}", float.Parse(FriedInterfaceCircuit) * e);
            EffectiveTrippedPowerCircuit = String.Format("{0:#,0.00}", float.Parse(TrippedPowerCircuit) * e);
            EffectiveSmashedTriggerUnit = String.Format("{0:#,0.00}", float.Parse(SmashedTriggerUnit) * e);
            EffectiveDamagedCloseinWeaponSystem = String.Format("{0:#,0.00}", float.Parse(DamagedCloseinWeaponSystem) * e);
            EffectiveScorchedTelemetryProcessor = String.Format("{0:#,0.00}", float.Parse(ScorchedTelemetryProcessor) * e);
            EffectiveContaminatedLorentzFluid = String.Format("{0:#,0.00}", float.Parse(ContaminatedLorentzFluid) * e);
            EffectiveConductivePolymer = String.Format("{0:#,0.00}", float.Parse(ConductivePolymer) * e);
            EffectiveContaminatedNaniteCompound = String.Format("{0:#,0.00}", float.Parse(ContaminatedNaniteCompound) * e);
            EffectiveDefectiveCurrentPump = String.Format("{0:#,0.00}", float.Parse(DefectiveCurrentPump) * e);
        }

        public string EffectiveTritanium { get; set; }
        public string EffectivePyerite { get; set; }
        public string EffectiveMexallon { get; set; }
        public string EffectiveIsogen { get; set; }
        public string EffectiveNocxium { get; set; }
        public string EffectiveZydrine { get; set; }
        public string EffectiveMegacyte { get; set; }
        public string EffectiveMorphite { get; set; }
        public string EffectiveLusteringAlloy { get; set; }
        public string EffectiveSheenCompound { get; set; }
        public string EffectiveGleamingAlloy { get; set; }
        public string EffectiveCondensedAlloy { get; set; }
        public string EffectivePreciousAlloy { get; set; }
        public string EffectiveMotleyCompound { get; set; }
        public string EffectiveFiberComposite { get; set; }
        public string EffectiveLucentCompound { get; set; }
        public string EffectiveOpulentCompound { get; set; }
        public string EffectiveGlossyCompound { get; set; }
        public string EffectiveCrystalCompound { get; set; }
        public string EffectiveDarkCompound { get; set; }
        public string EffectiveBaseMetals { get; set; }
        public string EffectiveHeavyMetals { get; set; }
        public string EffectiveReactiveMetals { get; set; }
        public string EffectiveNobleMetals { get; set; }
        public string EffectiveToxicMetals { get; set; }
        public string EffectiveReactiveGas { get; set; }
        public string EffectiveNobleGas { get; set; }
        public string EffectiveIndustrialFibers { get; set; }
        public string EffectiveSupertensilePlastics { get; set; }
        public string EffectivePolyaramids { get; set; }
        public string EffectiveCoolant { get; set; }
        public string EffectiveCondensates { get; set; }
        public string EffectiveConstructionBlocks { get; set; }
        public string EffectiveNanites { get; set; }
        public string EffectiveSilicateGlass { get; set; }
        public string EffectiveSmartfabUnits { get; set; }
        public string EffectiveCharredMicroCircuit { get; set; }
        public string EffectiveFriedInterfaceCircuit { get; set; }
        public string EffectiveTrippedPowerCircuit { get; set; }
        public string EffectiveSmashedTriggerUnit { get; set; }
        public string EffectiveDamagedCloseinWeaponSystem { get; set; }
        public string EffectiveScorchedTelemetryProcessor { get; set; }
        public string EffectiveContaminatedLorentzFluid { get; set; }
        public string EffectiveConductivePolymer { get; set; }
        public string EffectiveContaminatedNaniteCompound { get; set; }
        public string EffectiveDefectiveCurrentPump { get; set; }
    }
}
