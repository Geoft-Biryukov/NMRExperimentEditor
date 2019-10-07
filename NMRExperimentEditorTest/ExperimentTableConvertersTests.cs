using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditorTest
{
    [TestClass]
    public class ExperimentTableConvertersTests
    {        
        [TestMethod]
        public void ExperimentTableConvertersTestsFullTest()
        {
            // Arrange
            var table = new ExperimentTable()
            {
                ExperimentNumber = 1,
                FrequencyIndex = (ulong)0x1122334455,
                StausOfRelay = RelayStatus.Relay1 | RelayStatus.Relay3 | RelayStatus.Relay6,
                Silence1 = 0x12,
                NoiseLength = 0x23,
                Silence2 = 0x34,
                PhaseOfAPulse = 0x0b,
                APulseStart = 0x06,
                APulseContinue = 0x56,
                SilenceA = 0x6789,
                BPulsePhase = 0x0c,
                BPulseContinue = 0x0346,
                SilenceB = 0x3578,
                RepeatB = 0x54,
                EchoLength = 0x45,                
                RepeatExp = 0x67,
                DelayExp = 0x2756,
                DelayRecord = 0x8576,
            };

            // Apply

            byte[] byteTable = ExperimentTableConverters.GetBytes(table);

            Assert.IsNotNull(byteTable);

            var resultTable = ExperimentTableConverters.GetTable(byteTable, true);

            // Assert

           Assert.AreEqual(table.ExperimentNumber, resultTable.ExperimentNumber);        
           Assert.AreEqual(table.FrequencyIndex, resultTable.FrequencyIndex);
           Assert.AreEqual(table.GetRelayCode(), resultTable.GetRelayCode());
           Assert.AreEqual(table.Silence1, resultTable.Silence1);
           Assert.AreEqual(table.NoiseLength, resultTable.NoiseLength);
           Assert.AreEqual(table.CalibrationsNumber, resultTable.CalibrationsNumber);
           Assert.AreEqual(table.Silence2, resultTable.Silence2);
           Assert.AreEqual(table.PhaseOfAPulse, resultTable.PhaseOfAPulse);
           Assert.AreEqual(table.APulseStart, resultTable.APulseStart);
           Assert.AreEqual(table.APulseContinue, resultTable.APulseContinue);
           Assert.AreEqual(table.SilenceA, resultTable.SilenceA);
           Assert.AreEqual(table.BPulsePhase, resultTable.BPulsePhase);
           Assert.AreEqual(table.BPulseContinue, resultTable.BPulseContinue);
           Assert.AreEqual(table.SilenceB, resultTable.SilenceB);
           Assert.AreEqual(table.EchoLength, resultTable.EchoLength);
           Assert.AreEqual(table.RepeatB, resultTable.RepeatB);
           Assert.AreEqual(table.RepeatExp, resultTable.RepeatExp);
           Assert.AreEqual(table.DelayExp, resultTable.DelayExp);
           Assert.AreEqual(table.DelayRecord, resultTable.DelayRecord);
           Assert.AreEqual(table.AdditionalWord, resultTable.AdditionalWord);
        }

        [TestMethod]
        public void ExperimentTableConvertersTestsGetTableTest()
        {
            // Arrange
           // ushort[] tableShort = new ushort[] { 0x0000, 0x0001, 0x9999, 0x9a37, 0x1412, 0x0115, 0xC30B, 0x001d, 0x2020, 0x0010, 0x0010, 0x0505, 0x0200, 0x0800, 0x00CF, 0x0000 };
            ushort[] tableShort = new ushort[] { 0x0001, 0x0001, 0xA073, 0x9a05, 0x64C8, 0x0b64, 0x8210, 0x007d, 0x001a, 0x007d, 0x0009, 0x1401, 0x0000, 0x0800, 0x001F, 0x0000 };

            byte[] tableByte = new byte[tableShort.Length * sizeof(ushort)];
            for (int i = 0, j = 0; i < tableShort.Length; i++, j += 2)
            {
                var current = BitConverter.GetBytes(tableShort[i]);
                tableByte[j] = current[0];
                tableByte[j + 1] = current[1];
            }

            // Apply          

            var resultTable = ExperimentTableConverters.GetTable(tableByte);

            var freq = Helpers.GetFrequencyByFrequencyIndex(resultTable.FrequencyWord, 80);

            var tt = resultTable.GetArray();

            // Assert

           
        }
    }
}
