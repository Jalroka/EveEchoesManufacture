using System;
using System.Collections.Generic;
using System.Text;
using EveEchoesManufacture.Contracts;
using Newtonsoft.Json;

namespace EveEchoesManufacture.Services
{
    public class CostCalculatorService
    {
        public float CalculateCost(ManufacturableItem item, ResourceValues resourceValues, string efficiency)
        {
            float cost = 0f;
            float e = float.Parse(efficiency.Replace("%", "")) * .01f;

            cost += float.Parse(item.Tritanium) * resourceValues.Tritanium * e;
            cost += float.Parse(item.Pyerite) * resourceValues.Pyerite * e;
            cost += float.Parse(item.Mexallon) * resourceValues.Mexallon * e;
            cost += float.Parse(item.Isogen) * resourceValues.Isogen * e;
            cost += float.Parse(item.Nocxium) * resourceValues.Nocxium * e;
            cost += float.Parse(item.Zydrine) * resourceValues.Zydrine * e;
            cost += float.Parse(item.Megacyte) * resourceValues.Megacyte * e;
            cost += float.Parse(item.Morphite) * resourceValues.Morphite * e;
            cost += float.Parse(item.LusteringAlloy) * resourceValues.LusteringAlloy * e;
            cost += float.Parse(item.SheenCompound) * resourceValues.SheenCompound * e;
            cost += float.Parse(item.GleamingAlloy) * resourceValues.GleamingAlloy * e;
            cost += float.Parse(item.CondensedAlloy) * resourceValues.CondensedAlloy * e;
            cost += float.Parse(item.PreciousAlloy) * resourceValues.PreciousAlloy * e;
            cost += float.Parse(item.MotleyCompound) * resourceValues.MotleyCompound * e;
            cost += float.Parse(item.FiberComposite) * resourceValues.FiberComposite * e;
            cost += float.Parse(item.LucentCompound) * resourceValues.LucentCompound * e;
            cost += float.Parse(item.OpulentCompound) * resourceValues.OpulentCompound * e;
            cost += float.Parse(item.GlossyCompound) * resourceValues.GlossyCompound * e;
            cost += float.Parse(item.CrystalCompound) * resourceValues.CrystalCompound * e;
            cost += float.Parse(item.DarkCompound) * resourceValues.DarkCompound * e;
            cost += float.Parse(item.BaseMetals) * resourceValues.BaseMetals * e;
            cost += float.Parse(item.HeavyMetals) * resourceValues.HeavyMetals * e;
            cost += float.Parse(item.ReactiveMetals) * resourceValues.ReactiveMetals * e;
            cost += float.Parse(item.NobleMetals) * resourceValues.NobleMetals * e;
            cost += float.Parse(item.ToxicMetals) * resourceValues.ToxicMetals * e;
            cost += float.Parse(item.ReactiveGas) * resourceValues.ReactiveGas * e;
            cost += float.Parse(item.NobleGas) * resourceValues.NobleGas * e;
            cost += float.Parse(item.IndustrialFibers) * resourceValues.IndustrialFibers * e;
            cost += float.Parse(item.SupertensilePlastics) * resourceValues.SupertensilePlastics * e;
            cost += float.Parse(item.Polyaramids) * resourceValues.Polyaramids * e;
            cost += float.Parse(item.Coolant) * resourceValues.Coolant * e;
            cost += float.Parse(item.Condensates) * resourceValues.Condensates * e;
            cost += float.Parse(item.ConstructionBlocks) * resourceValues.ConstructionBlocks * e;
            cost += float.Parse(item.Nanites) * resourceValues.Nanites * e;
            cost += float.Parse(item.SilicateGlass) * resourceValues.SilicateGlass * e;
            cost += float.Parse(item.SmartfabUnits) * resourceValues.SmartfabUnits * e;
            cost += float.Parse(item.CharredMicroCircuit) * resourceValues.CharredMicroCircuit * e;
            cost += float.Parse(item.FriedInterfaceCircuit) * resourceValues.FriedInterfaceCircuit * e;
            cost += float.Parse(item.TrippedPowerCircuit) * resourceValues.TrippedPowerCircuit * e;
            cost += float.Parse(item.SmashedTriggerUnit) * resourceValues.SmashedTriggerUnit * e;
            cost += float.Parse(item.DamagedCloseinWeaponSystem) * resourceValues.DamagedCloseinWeaponSystem * e;
            cost += float.Parse(item.ScorchedTelemetryProcessor) * resourceValues.ScorchedTelemetryProcessor * e;
            cost += float.Parse(item.ContaminatedLorentzFluid) * resourceValues.ContaminatedLorentzFluid * e;
            cost += float.Parse(item.ConductivePolymer) * resourceValues.ConductivePolymer * e;
            cost += float.Parse(item.ContaminatedNaniteCompound) * resourceValues.ContaminatedNaniteCompound * e;
            cost += float.Parse(item.DefectiveCurrentPump) * resourceValues.DefectiveCurrentPump * e;


            return cost;
        }

        [JsonIgnore]
        public readonly List<string> BrokersFeeOptions = new List<string>
        {
            "8.0%",
            "7.8%",
            "7.6%",
            "7.2%",
            "7.0%",
            "6.8%",
            "6.6%",
            "6.2%",
            "6.0%",
            "5.8%",
            "5.6%",
            "5.2%",
            "5.0%",
        };

        [JsonIgnore]
        public readonly List<string> MarketTaxOptions = new List<string>
        {
            "15%",
            "14%",
            "13%",
            "12%",
            "11%",
            "10%",
        };
    }

}

