using NMRExperimentEditor.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.ViewModels
{
    /// <summary>
    /// Класс-обертка над ExperimentTable, предоставляющий
    /// связь с GUI
    /// </summary>
    internal class ExperimentTableViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private readonly ExperimentTable table;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public ExperimentTableViewModel(ExperimentTable table)
        {
            this.table = table ?? throw new ArgumentNullException(nameof(table));          
        }

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }

        [DisplayName("Номер эксперимента")]
        [Range(0, 5, ErrorMessage = "Bed")]        
        public decimal ExperimentNumber
        {
            get => table.ExperimentNumber;
        
            set
            {
                if ((ushort)value == table.ExperimentNumber)
                    return;

                if (value > 5)
                {
                    ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(ExperimentNumber)));
                    return;
                }

                table.ExperimentNumber = (ushort)value;
                OnPropertyChanged(nameof(ExperimentNumber));
            }
        }
        
        [DisplayName("Код частоты")]
        public decimal FrequencyIndex
        {
            get => table.FrequencyWord;
            set
            {
                if ((uint)value == table.FrequencyWord)
                    return;

                table.SetFrequency((uint)value);
                OnPropertyChanged(nameof(FrequencyIndex));
            }
        }

        [DisplayName("Фаза")]
        public decimal Phase
        {
            get => table.Phase;
            set
            {
                if ((uint)value == table.Phase)
                    return;

                table.SetPhase((byte)value);
                OnPropertyChanged(nameof(Phase));
            }
        }

        [DisplayName("Код реле")]
        public decimal RelayCode
        {
            get => table.GetRelayCode();
            set
            {
                if ((byte)value == table.GetRelayCode())
                    return;

                table.SetRelayCode((byte)value);
                OnPropertyChanged(nameof(RelayCode));
            }
        }

        [DisplayName("Тишина 1")]
        public decimal Silence1
        {
            get => table.Silence1;
            set
            {
                if ((byte)value == table.Silence1)
                    return;

                table.Silence1 = (byte)value;
                OnPropertyChanged(nameof(Silence1));
            }
        }

        [DisplayName("Длина шума")]
        public decimal NoiseLength
        {
            get => table.NoiseLength;
            set
            {
                if ((byte)value == table.NoiseLength)
                    return;

                table.NoiseLength = (byte)value;
                OnPropertyChanged(nameof(NoiseLength));
            }
        }

        [DisplayName("Число калибровочных выборок")]
        public decimal CalibrationsNumber
        {
            get => table.CalibrationsNumber;
            set
            {
                if ((byte)value == table.CalibrationsNumber)
                    return;

                table.CalibrationsNumber = (byte)value;
                OnPropertyChanged(nameof(CalibrationsNumber));
            }
        }

        [DisplayName("Тишина 2")]
        public decimal Silence2
        {
            get => table.Silence2;
            set
            {
                if ((byte)value == table.Silence2)
                    return;

                table.Silence2 = (byte)value;
                OnPropertyChanged(nameof(Silence2));
            }
        }

        [DisplayName("Фаза А-импульса")]        
        public decimal PhaseOfAPulse
        {
            get => table.PhaseOfAPulse;
            set
            {
                if ((byte)value == table.PhaseOfAPulse)
                    return;

                table.PhaseOfAPulse = (byte)value;
                OnPropertyChanged(nameof(PhaseOfAPulse));
            }
        }

        [DisplayName("Начало А")]
        public decimal APulseStart
        {
            get => table.APulseStart;
            set
            {
                if ((byte)value == table.APulseStart)
                    return;

                table.Silence1 = (byte)value;
                OnPropertyChanged(nameof(APulseStart));
            }
        }

        [DisplayName("Продолжение А")]        
        public decimal APulseContinue
        {
            get => table.APulseContinue;
            set
            {
                if ((byte)value == table.APulseContinue)
                    return;

                table.APulseContinue = (byte)value;
                OnPropertyChanged(nameof(APulseContinue));
            }
        }

        [DisplayName("Тишина А")]        
        public decimal SilenceA
        {
            get => table.SilenceA;
            set
            {
                if ((ushort)value == table.SilenceA)
                    return;

                table.SilenceA = (ushort)value;
                OnPropertyChanged(nameof(SilenceA));
            }
        }

        [DisplayName("Фаза B-импульса")]        
        public decimal BPulsePhase
        {
            get => table.BPulsePhase;
            set
            {
                if ((byte)value == table.BPulsePhase)
                    return;

                table.BPulsePhase = (byte)value;
                OnPropertyChanged(nameof(BPulsePhase));
            }
        }

        [DisplayName("Продолжение")]
        public decimal BPulseContinue
        {
            get => table.BPulseContinue;
            set
            {
                if ((ushort)value == table.BPulseContinue)
                    return;

                table.BPulseContinue = (ushort)value;
                OnPropertyChanged(nameof(BPulseContinue));
            }
        }

        [DisplayName("Тишина В")]        
        public decimal SilenceB
        {
            get => table.SilenceB;
            set
            {
                if ((ushort)value == table.SilenceB)
                    return;

                table.SilenceB = (ushort)value;
                OnPropertyChanged(nameof(SilenceB));
            }
        }

        [DisplayName("Количество повторений В-импульса")]         
        public decimal RepeatB
        {
            get => table.RepeatB;
            set
            {
                if ((ushort)value == table.RepeatB)
                    return;

                table.RepeatB = (ushort)value;
                OnPropertyChanged(nameof(RepeatB));
            }
        }

        [DisplayName("Длина эхо")]        
        public decimal EchoLength
        {
            get => table.EchoLength;
            set
            {
                if ((byte)value == table.EchoLength)
                    return;

                table.EchoLength = (byte)value;
                OnPropertyChanged(nameof(EchoLength));
            }
        }

        [DisplayName("Количество повторений экспериментов")]        
        public decimal RepeatExp
        {
            get => table.RepeatExp;
            set
            {
                if ((byte)value == table.RepeatExp)
                    return;

                table.RepeatExp = (byte)value;
                OnPropertyChanged(nameof(RepeatExp));
            }
        }

        [DisplayName(".Задержка между повторяющимися экспериментами")]        
        public decimal DelayExp
        {
            get => table.DelayExp;
            set
            {
                if ((ushort)value == table.DelayExp)
                    return;

                table.DelayExp = (ushort)value;
                OnPropertyChanged(nameof(DelayExp));
            }
        }

        [DisplayName("Задержка после завершения цикла одной записи")]        
        public decimal DelayRecord
        {
            get => table.DelayRecord;
            set
            {
                if ((ushort)value == table.DelayRecord)
                    return;

                table.DelayRecord = (ushort)value;
                OnPropertyChanged(nameof(DelayRecord));
            }
        }

        [DisplayName("Вспомогательное слово")]
        public decimal AdditionalWord
        {
            get => table.AdditionalWord;
            set
            {
                if ((ushort)value == table.AdditionalWord)
                    return;

                table.AdditionalWord = (ushort)value;
                OnPropertyChanged(nameof(AdditionalWord));
            }
        }

        public bool HasErrors => throw new NotImplementedException();
    }
}
