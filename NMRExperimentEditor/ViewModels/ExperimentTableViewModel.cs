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
    public class ExperimentTableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<ArrayData> WordsArray { get; } = new BindingList<ArrayData>();

        public ExperimentTableViewModel(ExperimentTable table)
        {
            Experimenent = table ?? throw new ArgumentNullException(nameof(table));
            InitializeArray();
            PropertyChanged += ExperimentTableViewModelChanged;
            UpdateArray();
        }

        private void InitializeArray()
        {
            WordsArray.Clear();

            for (int i = 0; i < 16; i++)
            {
                var name = $"T{i + 1}.{ExperimentNumber}";
                WordsArray.Add(new ArrayData(name, 0));
            }
        }

        private void ExperimentTableViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateArray();
        }

        private void UpdateArray()
        {
            var ar = Experimenent.GetArray();
            for (int i = 0; i < ar.Length; i++)
            {
                WordsArray[i].NumericValue = ar[i];
            }
        }
       
        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));       

        [DisplayName("Номер эксперимента")]
        [Range(0, 5, ErrorMessage = "Bed")]        
        public decimal ExperimentNumber
        {
            get => Experimenent.ExperimentNumber;
        
            set
            {
                if ((ushort)value == Experimenent.ExperimentNumber)
                    return;               

                Experimenent.ExperimentNumber = (ushort)value;
                OnPropertyChanged(nameof(ExperimentNumber));
            }
        }
        
        [DisplayName("Код частоты")]
        public decimal FrequencyIndex
        {
            get => Experimenent.FrequencyWord;
            set
            {
                if ((uint)value == Experimenent.FrequencyWord)
                    return;

                Experimenent.SetFrequency((uint)value);
                OnPropertyChanged(nameof(FrequencyIndex));
            }
        }

        [DisplayName("Фаза")]
        public decimal Phase
        {
            get => Experimenent.Phase;
            set
            {
                if ((uint)value == Experimenent.Phase)
                    return;

                Experimenent.SetPhase((byte)value);
                OnPropertyChanged(nameof(Phase));
            }
        }

        [DisplayName("Код реле")]
        public decimal RelayCode
        {
            get => Experimenent.GetRelayCode();
            set
            {
                if ((byte)value == Experimenent.GetRelayCode())
                    return;

                Experimenent.SetRelayCode((byte)value);
                OnPropertyChanged(nameof(RelayCode));
            }
        }

        [DisplayName("Тишина 1")]
        public decimal Silence1
        {
            get => Experimenent.Silence1;
            set
            {
                if ((byte)value == Experimenent.Silence1)
                    return;

                Experimenent.Silence1 = (byte)value;
                OnPropertyChanged(nameof(Silence1));
            }
        }

        [DisplayName("Длина шума")]
        public decimal NoiseLength
        {
            get => Experimenent.NoiseLength;
            set
            {
                if ((byte)value == Experimenent.NoiseLength)
                    return;

                Experimenent.NoiseLength = (byte)value;
                OnPropertyChanged(nameof(NoiseLength));
            }
        }

        [DisplayName("Число калибровочных выборок")]
        public decimal CalibrationsNumber
        {
            get => Experimenent.CalibrationsNumber;
            set
            {
                if ((byte)value == Experimenent.CalibrationsNumber)
                    return;

                Experimenent.CalibrationsNumber = (byte)value;
                OnPropertyChanged(nameof(CalibrationsNumber));
            }
        }

        [DisplayName("Тишина 2")]
        public decimal Silence2
        {
            get => Experimenent.Silence2;
            set
            {
                if ((byte)value == Experimenent.Silence2)
                    return;

                Experimenent.Silence2 = (byte)value;
                OnPropertyChanged(nameof(Silence2));
            }
        }

        [DisplayName("Фаза А-импульса")]        
        public decimal PhaseOfAPulse
        {
            get => Experimenent.PhaseOfAPulse;
            set
            {
                if ((byte)value == Experimenent.PhaseOfAPulse)
                    return;

                Experimenent.PhaseOfAPulse = (byte)value;
                OnPropertyChanged(nameof(PhaseOfAPulse));
            }
        }

        [DisplayName("Начало А")]
        public decimal APulseStart
        {
            get => Experimenent.APulseStart;
            set
            {
                if ((byte)value == Experimenent.APulseStart)
                    return;

                Experimenent.APulseStart = (byte)value;
                OnPropertyChanged(nameof(APulseStart));
            }
        }

        [DisplayName("Продолжение А")]        
        public decimal APulseContinue
        {
            get => Experimenent.APulseContinue;
            set
            {
                if ((byte)value == Experimenent.APulseContinue)
                    return;

                Experimenent.APulseContinue = (byte)value;
                OnPropertyChanged(nameof(APulseContinue));
            }
        }

        [DisplayName("Тишина А")]        
        public decimal SilenceA
        {
            get => Experimenent.SilenceA;
            set
            {
                if ((ushort)value == Experimenent.SilenceA)
                    return;

                Experimenent.SilenceA = (ushort)value;
                OnPropertyChanged(nameof(SilenceA));
            }
        }

        [DisplayName("Фаза B-импульса")]        
        public decimal BPulsePhase
        {
            get => Experimenent.BPulsePhase;
            set
            {
                if ((byte)value == Experimenent.BPulsePhase)
                    return;

                Experimenent.BPulsePhase = (byte)value;
                OnPropertyChanged(nameof(BPulsePhase));
            }
        }

        [DisplayName("Продолжение")]
        public decimal BPulseContinue
        {
            get => Experimenent.BPulseContinue;
            set
            {
                if ((ushort)value == Experimenent.BPulseContinue)
                    return;

                Experimenent.BPulseContinue = (ushort)value;
                OnPropertyChanged(nameof(BPulseContinue));
            }
        }

        [DisplayName("Тишина В")]        
        public decimal SilenceB
        {
            get => Experimenent.SilenceB;
            set
            {
                if ((ushort)value == Experimenent.SilenceB)
                    return;

                Experimenent.SilenceB = (ushort)value;
                OnPropertyChanged(nameof(SilenceB));
            }
        }

        [DisplayName("Количество повторений В-импульса")]         
        public decimal RepeatB
        {
            get => Experimenent.RepeatB;
            set
            {
                if ((ushort)value == Experimenent.RepeatB)
                    return;

                Experimenent.RepeatB = (ushort)value;
                OnPropertyChanged(nameof(RepeatB));
            }
        }

        [DisplayName("Длина эхо")]        
        public decimal EchoLength
        {
            get => Experimenent.EchoLength;
            set
            {
                if ((byte)value == Experimenent.EchoLength)
                    return;

                Experimenent.EchoLength = (byte)value;
                OnPropertyChanged(nameof(EchoLength));
            }
        }

        [DisplayName("Количество повторений экспериментов")]        
        public decimal RepeatExp
        {
            get => Experimenent.RepeatExp;
            set
            {
                if ((byte)value == Experimenent.RepeatExp)
                    return;

                Experimenent.RepeatExp = (byte)value;
                OnPropertyChanged(nameof(RepeatExp));
            }
        }

        [DisplayName(".Задержка между повторяющимися экспериментами")]        
        public decimal DelayExp
        {
            get => Experimenent.DelayExp;
            set
            {
                if ((ushort)value == Experimenent.DelayExp)
                    return;

                Experimenent.DelayExp = (ushort)value;
                OnPropertyChanged(nameof(DelayExp));
            }
        }

        [DisplayName("Задержка после завершения цикла одной записи")]        
        public decimal DelayRecord
        {
            get => Experimenent.DelayRecord;
            set
            {
                if ((ushort)value == Experimenent.DelayRecord)
                    return;

                Experimenent.DelayRecord = (ushort)value;
                OnPropertyChanged(nameof(DelayRecord));
            }
        }

        [DisplayName("Вспомогательное слово")]
        public decimal AdditionalWord
        {
            get => Experimenent.AdditionalWord;
            set
            {
                if ((ushort)value == Experimenent.AdditionalWord)
                    return;

                Experimenent.AdditionalWord = (ushort)value;
                OnPropertyChanged(nameof(AdditionalWord));
            }
        }
        
        public bool IsLast
        {
            get => Experimenent.IsLast;
            set
            {
                if (value == Experimenent.IsLast)
                    return;

                Experimenent.IsLast = value;
                OnPropertyChanged(nameof(IsLast));
            }
        }

        public ExperimentTable Experimenent { get; }

        public override string ToString()
        {
            return $"Эксперимент {ExperimentNumber}";
        }
    }
}
