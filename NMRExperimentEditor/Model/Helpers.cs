using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Model
{
    internal static class Helpers
    {
        public static byte RelayStatusToByte(RelayStatus relay)
        {
            byte result = 0;

            foreach (RelayStatus value in Enum.GetValues(typeof(RelayStatus)))
            {
                if (relay.HasFlag(value))
                {
                    result |= (byte)value;
                }
            }

            return result;
        }

        public static RelayStatus ByteToRelayStatus(byte code)
        {
            RelayStatus result = RelayStatus.Empty;

            if (IsBitSet(code, (int)RelayStatus.Relay1)) result |= RelayStatus.Relay1;
            if (IsBitSet(code, (int)RelayStatus.Relay2)) result |= RelayStatus.Relay2;
            if (IsBitSet(code, (int)RelayStatus.Relay3)) result |= RelayStatus.Relay3;
            if (IsBitSet(code, (int)RelayStatus.Relay4)) result |= RelayStatus.Relay4;
            if (IsBitSet(code, (int)RelayStatus.Relay5)) result |= RelayStatus.Relay5;
            if (IsBitSet(code, (int)RelayStatus.Relay6)) result |= RelayStatus.Relay6;

            return result;
        }

        private static bool IsBitSet(byte b, int flag) => (b & flag) != 0;

        public static double GetFrequencyByFrequencyIndex(uint index, double SysClk)
        {
            ulong divider = (ulong)1 << 32;
            return index * SysClk / divider;
        }

        public static uint GetFrequencyIndexByFrequency(double frequency, double SysClk)
        {
            ulong multipler = (ulong)1 << 32;
            return (uint)(frequency * multipler / SysClk);
        }
    }
}
