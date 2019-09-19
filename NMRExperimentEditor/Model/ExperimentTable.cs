using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Model
{
    class ExperimentTable
    {
        /// <summary>
        /// 1. Номер эксперимента (Nr)
        /// </summary>
        public ushort ExperimentNumber { get; set; }

        /// <summary>
        /// 2. Код частоты (Fc)
        /// </summary>
        public ulong FrequencyIndex { get; set; }

        /// <summary>
        /// Вычисляет слово частоты
        /// Из документации: ([31:0] - слово частоты)
        /// </summary>
        public uint FrequencyWord
        {
            get => (uint)(FrequencyIndex & 0xFFFFFFFF);            
        }

        /// <summary>
        /// Вычисляет фазу
        /// Из Документации: [36:32] - фаза, [37:39] - служебные биты - равны нулю
        /// </summary>
        public byte Phase
        {
            get => (byte)((FrequencyIndex >> 32) & 0xFF);            
        }
                
        /// <summary>
        /// 3. Состояние реле
        /// </summary>
        public RelayStatus StausOfRelay { get; set; }

        /// <summary>
        /// Вычисляет код реле по состоянию реле (Rc)
        /// </summary>
        /// <returns>Текущий код реле</returns>
        public byte GetRelayCode() 
            => Helpers.RelayStatusToByte(StausOfRelay);

        /// <summary>
        /// Устанавливает состояние реле по коду реле
        /// </summary>
        /// <param name="code"> Код реле</param>
        public void SetRelayCode(byte code) 
            => StausOfRelay = Helpers.ByteToRelayStatus(code);

        /// <summary>
        /// 4. Тишина1 (задержка после замера калибровочных импульсов
        /// до начала A-импульса) (S1)
        /// </summary>
        public byte Silence1 { get; set; }

        /// <summary>
        /// 5. Длина шума (после замера шума также
        ///  выдерживается задержка S1) (Ln)
        /// </summary>
        public byte NoiseLength { get; set; }

        /// <summary>
        /// 6. Число калибровочных выборок (Ncal)
        /// </summary>
        public byte CalibrationsNumber { get; set; }

        /// <summary>
        /// 7. Тишина 2 (задержка после замера
        /// калибровочных импульсов до начала А-импульса) (S2)
        /// </summary>
        public byte Silence2 { get; set; }

        /// <summary>
        /// 8. Фаза А-импульса (Aph)
        /// </summary>
        public byte PhaseOfAPulse { get; set; }

        /// <summary>
        /// 9. Начало А (Ast)
        /// </summary>
        public byte APulseStart { get; set; }

        /// <summary>
        /// 10. Продолжение А (Asu)
        /// </summary>
        public byte APulseContinue { get; set; }

        /// <summary>
        /// 11. Тишина А (задержка после завершения А-
        /// импульса до начала В-импульса) (Sa)
        /// </summary>
        public ushort SilenceA { get; set; }

        /// <summary>
        /// 12. Фаза B-импульса (Bph)
        /// </summary>
        public byte BPulsePhase { get; set; }

        /// <summary>
        /// 13. Продолжение В (Bsu)
        /// </summary>
        public ushort BPulseContinue { get; set; }

        /// <summary>
        /// 14. Тишина В (задержка после завершения В-
        /// импульса до начала замера эхо) (Sb)
        /// </summary>
        public ushort SilenceB { get; set; }

        /// <summary>
        /// 16.Количество повторений В-импульса (Brep) 
        /// </summary>
        public ushort RepeatB { get; set; }
        
        /// <summary>
        /// 15. Длина эхо (Le)
        /// </summary>
        public byte EchoLength { get; set; }
       
        /// <summary>
        /// 17. Количество повторений экспериментов (Srep) 
        /// </summary>
        public byte RepeatExp { get; set; }

        /// <summary>
        /// 18.Задержка между повторяющимися
        /// экспериментами (Dexp)
        /// </summary>
        public ushort DelayExp { get; set; }

        /// <summary>
        /// 19.Задержка после завершения цикла одной записи (Drec)
        /// </summary>
        public ushort DelayRecord { get; set; }

        /// <summary>
        /// 20. Вспомогательное слово (Sp)
        /// </summary>
        public ushort AdditionalWord { get; set; }

        #region Get array
        public ushort[] GetArray()
        {
            var words = new ushort[15];

            words[0] = ExperimentNumber;

            var freqAndRel = GetFrequencyAndRelay(FrequencyIndex, GetRelayCode());
            words[1] = freqAndRel[0];
            words[2] = freqAndRel[1];
            words[3] = freqAndRel[2];

            words[4] = ToUshort(Silence1, NoiseLength);
            words[5] = ToUshort(CalibrationsNumber, Silence2); 
            words[6] = ToUshort(Join4x4(PhaseOfAPulse, APulseStart), APulseContinue);
            words[7] = SilenceA;
            words[8] = Join4x12(BPulsePhase, BPulseContinue);
            words[9] = SilenceB;
            words[10] = RepeatB;
            words[11] = ToUshort(EchoLength, RepeatExp);
            words[12] = DelayExp;
            words[13] = DelayRecord;
            words[14] = AdditionalWord;

            return words;
        }
       
        private static ushort[] GetFrequencyAndRelay(ulong freq, byte relayCode)
        {
            var result = new ushort[3];
            result[0] = (ushort)((freq >> 24) & 0xFFFF);
            result[1] = (ushort)((freq >> 8) & 0xFFFF);
            result[2] = (ushort)(((freq << 8) & 0xFF00) | relayCode);

            return result;
        }

        public static ushort ToUshort(byte upper, byte lower) 
            => (ushort)(((upper << 8) & 0xFF00) | lower);
        

        public static byte Join4x4(byte upper, byte lower) 
            => (byte)(upper << 4 | (lower & 0x0F));
        
        private static ushort  Join4x12(byte upper, ushort lower) 
            => (ushort)(((upper << 12) & 0xF000) | (lower & 0x0FFF));
        #endregion

        #region Set array
        public void SetArray(ushort[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException(nameof(words));
            }

            ExperimentNumber = words[0];
            GetFrequencyAndRelay(words[1], words[2], words[3], out ulong freq, out byte relayCode);
            FrequencyIndex = freq;
            SetRelayCode(relayCode);

            Decompose(words[4], out byte silence1, out byte noiseLength);
            Silence1 = silence1;
            NoiseLength = noiseLength;

            Decompose(words[5], out byte calibrationsCount, out byte silence2);
            CalibrationsNumber = calibrationsCount;
            Silence2 = silence2;

            Decompose(words[6], out byte upper, out byte lower);
            Decompose(upper, out byte aPhase, out byte aStart);
            PhaseOfAPulse = aPhase;
            APulseStart = aStart;
            APulseContinue = lower;

            SilenceA = words[7];

            Decompose4x12(words[8], out byte bPhase, out ushort bContinue);
            BPulsePhase = bPhase;
            BPulseContinue = bContinue;

            SilenceB = words[9];
            RepeatB = words[10];

            Decompose(words[11], out byte echoLength, out byte expRepeat);
            EchoLength = echoLength;
            RepeatExp = expRepeat;

            DelayExp = words[12];
            DelayRecord = words[13];
            AdditionalWord = words[14];
        }

        private static void GetFrequencyAndRelay(ushort word1, ushort word2, ushort word3, out ulong freq, out byte relayCode)
        {
            relayCode = (byte) (word3 & 0x00FF);

            freq = (ulong)word1 << 24;
            freq = freq | (ulong)word2 << 8;
            freq = freq | (ulong)word3 >> 8;
        }

        private static void Decompose(ushort word, out byte upper, out byte lower)
        {
            upper = (byte)(word >> 8);
            lower = (byte)(word & 0x00FF);
        }

        private static void Decompose(byte bits, out byte upper, out byte lower)
        {
            upper = (byte)((bits >> 4) & 0x0F);
            lower = (byte)(bits & 0x0F);
        }

        private static void Decompose4x12(ushort word, out byte upper, out ushort lower)
        {
            upper = (byte)((word >> 12) & 0x000F);
            lower = (ushort)(word & 0x0FFF);
        }
        #endregion
    }
}
