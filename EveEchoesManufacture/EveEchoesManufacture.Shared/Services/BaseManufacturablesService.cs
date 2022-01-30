using CsvHelper;
using EveEchoesManufacture.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace EveEchoesManufacture.Services
{
    public class BaseManufacturablesService
    {
        public List<ManufacturableItem> GetManufacturable()
        {
            List<ManufacturableItem> Items = new List<ManufacturableItem>();

            var assembly = Assembly.GetExecutingAssembly();
            var resources = assembly.GetManifestResourceNames();
            var resourceName = resources[0];

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Do any configuration to `CsvReader` before creating CsvDataReader.
                using (var dr = new CsvDataReader(csv))
                {
                    var dt = new DataTable();
                    dt.Load(dr);

                    for (int col = 1; col < dt.Columns.Count; col++)
                    {
                        //int row = 1;

                        //var r = dt.Rows[row];

                        //foreach(var t in r.ItemArray)
                        //var t = (string)dt.Rows[0].ItemArray[col];
                        Items.Add(new ManufacturableItem
                        {
                            Name = dt.Columns[col].ColumnName,
                            Type = (string)dt.Rows[0].ItemArray[col],
                            TechLevel = (string)dt.Rows[1].ItemArray[col],
                            Tritanium = (string)dt.Rows[2].ItemArray[col],
                            Pyerite = (string)dt.Rows[3].ItemArray[col],
                            Mexallon = (string)dt.Rows[4].ItemArray[col],
                            Isogen = (string)dt.Rows[5].ItemArray[col],
                            Nocxium = (string)dt.Rows[6].ItemArray[col],
                            Zydrine = (string)dt.Rows[7].ItemArray[col],
                            Megacyte = (string)dt.Rows[8].ItemArray[col],
                            Morphite = (string)dt.Rows[9].ItemArray[col],
                            LusteringAlloy = (string)dt.Rows[10].ItemArray[col],
                            SheenCompound = (string)dt.Rows[11].ItemArray[col],
                            GleamingAlloy = (string)dt.Rows[12].ItemArray[col],
                            CondensedAlloy = (string)dt.Rows[13].ItemArray[col],
                            PreciousAlloy = (string)dt.Rows[14].ItemArray[col],
                            MotleyCompound = (string)dt.Rows[15].ItemArray[col],
                            FiberComposite = (string)dt.Rows[16].ItemArray[col],
                            LucentCompound = (string)dt.Rows[17].ItemArray[col],
                            OpulentCompound = (string)dt.Rows[18].ItemArray[col],
                            GlossyCompound = (string)dt.Rows[19].ItemArray[col],
                            CrystalCompound = (string)dt.Rows[20].ItemArray[col],
                            DarkCompound = (string)dt.Rows[21].ItemArray[col],
                            BaseMetals = (string)dt.Rows[22].ItemArray[col],
                            HeavyMetals = (string)dt.Rows[23].ItemArray[col],
                            ReactiveMetals = (string)dt.Rows[24].ItemArray[col],
                            NobleMetals = (string)dt.Rows[25].ItemArray[col],
                            ToxicMetals = (string)dt.Rows[26].ItemArray[col],
                            ReactiveGas = (string)dt.Rows[27].ItemArray[col],
                            NobleGas = (string)dt.Rows[28].ItemArray[col],
                            IndustrialFibers = (string)dt.Rows[29].ItemArray[col],
                            SupertensilePlastics = (string)dt.Rows[30].ItemArray[col],
                            Polyaramids = (string)dt.Rows[31].ItemArray[col],
                            Coolant = (string)dt.Rows[32].ItemArray[col],
                            Condensates = (string)dt.Rows[33].ItemArray[col],
                            ConstructionBlocks = (string)dt.Rows[34].ItemArray[col],
                            Nanites = (string)dt.Rows[35].ItemArray[col],
                            SilicateGlass = (string)dt.Rows[36].ItemArray[col],
                            SmartfabUnits = (string)dt.Rows[37].ItemArray[col],
                            CharredMicroCircuit = (string)dt.Rows[38].ItemArray[col],
                            FriedInterfaceCircuit = (string)dt.Rows[39].ItemArray[col],
                            TrippedPowerCircuit = (string)dt.Rows[40].ItemArray[col],
                            SmashedTriggerUnit = (string)dt.Rows[41].ItemArray[col],
                            DamagedCloseinWeaponSystem = (string)dt.Rows[42].ItemArray[col],
                            ScorchedTelemetryProcessor = (string)dt.Rows[43].ItemArray[col],
                            ContaminatedLorentzFluid = (string)dt.Rows[44].ItemArray[col],
                            ConductivePolymer = (string)dt.Rows[45].ItemArray[col],
                            ContaminatedNaniteCompound = (string)dt.Rows[46].ItemArray[col],
                            DefectiveCurrentPump = (string)dt.Rows[47].ItemArray[col],
                            ProductionCost = (string)dt.Rows[48].ItemArray[col],
                            ProductionTime = (string)dt.Rows[49].ItemArray[col],
                            ProductionCount = (string)dt.Rows[50].ItemArray[col],
                        });
                    }
                }
            }

            return Items;
        }
    }
}
