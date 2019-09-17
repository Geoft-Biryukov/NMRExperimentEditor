using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditorTest
{
    [TestClass]
    public class ExperimentTableConvertersTests
    {
        [TestMethod]
        public void ExperimentTableConvertersTestsJointBytesTest()
        {
            // Arrange
            byte upper1 = 1;
            byte lower1 = 1;
            byte expected1 = Convert.ToByte("00010001", 2);

            byte upper2 = 10;
            byte lower2 = 10;
            byte expected2 = Convert.ToByte("10101010", 2);

            byte upper3 = 15;
            byte lower3 = 15;
            byte expected3 = Convert.ToByte("11111111", 2);

            // Apply
            var actual1 = ExperimentTableConverters.Join(upper1, lower1);
            var actual2 = ExperimentTableConverters.Join(upper2, lower2);
            var actual3 = ExperimentTableConverters.Join(upper3, lower3);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void ExperimentTableConvertersTestsFullTest()
        {
            // Arrange
            var table = new ExperimentTable()
            {
                ExperimentNumber = 1,
                FrequencyIndex = 111,
                StausOfRelay = RelayStatus.Relay1 | RelayStatus.Relay3 | RelayStatus.Relay6,
                Silence1 = 200,
                NoiseLength = 200,
                Silence2 = 200,
                PhaseOfAPulse = 14,
                APulseStart = 14,
                APulseContinue = 200,
                SilenceA = 200,
                BPulsePhase = 10,
                BPulseContinue = 200,
                SilenceB = 200, EchoLength = 200, RepeatB = 1000, RepeatExp = 200, DelayExp = 1000, DelayRecord = 1000,  
            };

            // Apply

            byte[] byteTable = ExperimentTableConverters.GetBytes(table);

            Assert.IsNotNull(byteTable);

            var resultTable = ExperimentTableConverters.GetTable(byteTable);

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
            ushort[] tableShort = new ushort[] { 0x0000, 0x0001, 0x9999, 0x9a37, 0x1412, 0x0115, 0xC30B, 0x001d, 0x2020, 0x0010, 0x0010, 0x0505, 0x0200, 0x0800, 0x00CF, 0x0000 };
            byte[] tableByte = new byte[tableShort.Length * sizeof(ushort)];
            for (int i = 0, j = 0; i < tableShort.Length; i++, j += 2)
            {
                var current = BitConverter.GetBytes(tableShort[i]);
                tableByte[j] = current[1];
                tableByte[j + 1] = current[0];
            }

            // Apply          

            var resultTable = ExperimentTableConverters.GetTable(tableByte);

            // Assert

            //Assert.AreEqual(table.ExperimentNumber, resultTable.ExperimentNumber);
            //Assert.AreEqual(table.FrequencyIndex, resultTable.FrequencyIndex);
            //Assert.AreEqual(table.GetRelayCode(), resultTable.GetRelayCode());
            //Assert.AreEqual(table.Silence1, resultTable.Silence1);
            //Assert.AreEqual(table.NoiseLength, resultTable.NoiseLength);
            //Assert.AreEqual(table.CalibrationsNumber, resultTable.CalibrationsNumber);
            //Assert.AreEqual(table.Silence2, resultTable.Silence2);
            //Assert.AreEqual(table.PhaseOfAPulse, resultTable.PhaseOfAPulse);
            //Assert.AreEqual(table.APulseStart, resultTable.APulseStart);
            //Assert.AreEqual(table.APulseContinue, resultTable.APulseContinue);
            //Assert.AreEqual(table.SilenceA, resultTable.SilenceA);
            //Assert.AreEqual(table.BPulsePhase, resultTable.BPulsePhase);
            //Assert.AreEqual(table.BPulseContinue, resultTable.BPulseContinue);
            //Assert.AreEqual(table.SilenceB, resultTable.SilenceB);
            //Assert.AreEqual(table.EchoLength, resultTable.EchoLength);
            //Assert.AreEqual(table.RepeatB, resultTable.RepeatB);
            //Assert.AreEqual(table.RepeatExp, resultTable.RepeatExp);
            //Assert.AreEqual(table.DelayExp, resultTable.DelayExp);
            //Assert.AreEqual(table.DelayRecord, resultTable.DelayRecord);
            //Assert.AreEqual(table.AdditionalWord, resultTable.AdditionalWord);
        }
    }
}
