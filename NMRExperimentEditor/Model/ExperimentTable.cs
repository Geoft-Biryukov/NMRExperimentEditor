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
        /// 3. Состояние реле
        /// </summary>
        public RelayStatus StausOfRelay { get; set; }

        /// <summary>
        /// Вычисляет код реле по состоянию реле (Rc)
        /// </summary>
        /// <returns>Текущий код реле</returns>
        public byte GetRelayCode() => Helpers.RelayStatusToByte(StausOfRelay);

        /// <summary>
        /// Устанавливает состояние реле по коду реле
        /// </summary>
        /// <param name="code"> Код реле</param>
        public void SetRelayCode(byte code) => StausOfRelay = Helpers.ByteToRelayStatus(code);

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
        /// 15. Длина эхо (Le)
        /// </summary>
        public byte EchoLength { get; set; }

        /// <summary>
        /// 16.Количество повторений В-импульса (Brep) 
        /// </summary>
        public ushort RepeatB { get; set; }

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
    }
}
