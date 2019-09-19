using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Model
{
    internal static class ExperimentTableConverters
    {        
        public static byte[] GetBytes(ExperimentTable table, bool crcFlag = true)
        {
            if (table == null)            
                throw new ArgumentNullException(nameof(table));            

            var result = new List<byte>(32);

            var array = table.GetArray();

            foreach (var item in array)
            {
                result.AddRange(BitConverter.GetBytes(item));
            }

            if (crcFlag)
            {
                var crc = CalculateCrc(array);
                result.AddRange(BitConverter.GetBytes(crc));
            }

            return result.ToArray();            
        }

        private static ushort CalculateCrc(ushort[] source)
        {
            int sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }
            return (ushort)(~sum);
        }                
        
        public static ExperimentTable GetTable(byte[] sourceBytes, bool checkCrc = false)
        {
            if (sourceBytes == null)            
                throw new ArgumentNullException(nameof(sourceBytes));
            
            if (sourceBytes.Length < 30)            
                throw new ArgumentException($"{nameof(sourceBytes)}.Length < 30");

            if (checkCrc && sourceBytes.Length < 32)
                throw new ArgumentException("crc not found");

            var result = new ExperimentTable();

            var count = sourceBytes.Length / sizeof(ushort);
            var words = new ushort[count];

            for (int i = 0, j = 0; i < sourceBytes.Length; i += 2, j++)
            {
                words[j] = BitConverter.ToUInt16(sourceBytes, i);
            }

            if(checkCrc && !ChekCrc(words))
            {
                throw new ArgumentException("Crc is incorrect!");
            }

            result.SetArray(words);            

            return result;            
        }

        private static bool ChekCrc(ushort[] words)
        {
            ushort sum = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                sum += words[i];
            }

            return (ushort)(~sum) == words[words.Length - 1];
        }
    }
}
