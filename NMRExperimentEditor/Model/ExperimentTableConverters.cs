using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Model
{
    internal static class ExperimentTableConverters
    {
        #region Convert Experiment table to byte array
        public static byte[] GetBytes(ExperimentTable table)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            var result = new List<byte>(32);

            AddUshort(result, table.ExperimentNumber);            

            var freq = BitConverter.GetBytes(table.FrequencyIndex);
            result.AddRange(freq.Take(5));

            result.Add(table.GetRelayCode());
            result.Add(table.Silence1);
            result.Add(table.NoiseLength);
            result.Add(table.CalibrationsNumber);
            result.Add(table.Silence2);

            result.Add(Join(table.PhaseOfAPulse, table.APulseStart));

            result.Add(table.APulseContinue);

            AddUshort(result, table.SilenceA);
            
            result.AddRange(Join(table.BPulsePhase, table.BPulseContinue));

            AddUshort(result, table.SilenceB);
            
            result.Add(table.EchoLength);

            AddUshort(result, table.RepeatB);

            result.Add(table.RepeatExp);

            AddUshort(result, table.DelayExp);
            AddUshort(result, table.DelayRecord);
            AddUshort(result, table.AdditionalWord);

            AddUshort(result, GetCrc(result));

            return result.ToArray();            
        }

        private static ushort GetCrc(List<byte> result)
        {
            ushort crc = (ushort)result.Sum(item => item);            
            return (ushort)~crc;
        }

        private static void AddShort(List<byte> list, short item)
        {
            var items = BitConverter.GetBytes(item);
            list.AddRange(items.Reverse());
        }

        private static void AddUshort(List<byte> list, ushort item)
        {
            var items = BitConverter.GetBytes(item);
            list.AddRange(items.Reverse());
        }

        public static byte Join(byte upper, byte lower)
        {
            return (byte)(upper << 4 | (lower & 0x0F));
        }

        public static byte[] Join(byte upper, ushort lower)
        {
            var lowerBytes = BitConverter.GetBytes(lower);

            return new byte[] { Join(upper, lowerBytes[0]), lowerBytes[1] };
        }
        #endregion

        #region Convert byte array to experiment table
        public static ExperimentTable GetTable(byte[] sourceBytes)
        {
            if (sourceBytes == null)
            {
                throw new ArgumentNullException(nameof(sourceBytes));
            }

            if (sourceBytes.Length != 32)
            {
                throw new ArgumentException($"{nameof(sourceBytes)}.Length != 64");
            }

            int currentIndex = 0;
            var result = new ExperimentTable();
            
            result.ExperimentNumber = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            result.FrequencyIndex = CreateFrequencyIndex(sourceBytes, currentIndex);
            currentIndex += 5;

            result.SetRelayCode(sourceBytes[currentIndex++]);
            result.Silence1 = sourceBytes[currentIndex++];
            result.NoiseLength = sourceBytes[currentIndex++];
            result.CalibrationsNumber = sourceBytes[currentIndex++];
            result.Silence2 = sourceBytes[currentIndex++];

            DecomposeByte(sourceBytes[currentIndex++], out byte APhas, out byte AStart);
            result.PhaseOfAPulse = APhas;
            result.APulseStart = AStart;

            result.APulseContinue = sourceBytes[currentIndex++];
            result.SilenceA = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            var source = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);
            DecomposeByte(source, out byte bPhase, out ushort bContinue);
            result.BPulsePhase = bPhase;
            result.BPulseContinue = bContinue;

            result.SilenceB = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            result.EchoLength = sourceBytes[currentIndex++];

            result.RepeatB = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            result.RepeatExp = sourceBytes[currentIndex++];

            result.DelayExp = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            result.DelayRecord = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            result.AdditionalWord = BitConverter.ToUInt16(sourceBytes, currentIndex);
            currentIndex += sizeof(short);

            short crc = BitConverter.ToInt16(sourceBytes, currentIndex);

            return result;            
        }

        private static ulong CreateFrequencyIndex(byte[] sourceBytes, int index)
        {            
            byte[] bytes = new byte[8];
            Array.Copy(sourceBytes, index, bytes, 0, 5);            
            return BitConverter.ToUInt64(bytes, 0); 
        }

        private static void DecomposeByte(byte source, out byte upper, out byte lower)
        {
            upper = (byte)((source & 0xF0) >> 4);
            lower = (byte)(source & 0x0F);
        }

        private static void DecomposeByte(ushort source, out byte upper, out ushort lower)
        {
            upper = (byte)((byte)(source & 0xF000) >> 4);
            lower = (ushort)(source & 0x0FFF);
        }
        #endregion
    }
}
