using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.ViewModels
{
    public class ArrayData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ArrayData(string name, ushort value)
        {
            Name = name;
            NumericValue = value;
        }

        private string name = string.Empty;
        [DisplayName("Слово")]
        [ReadOnly(true)]
        public string Name
        {
            get => name;
            set => Set(nameof(Name), ref name, value);                        
        }
        
        [DisplayName("Величина, hex")]
        [ReadOnly(true)]
        public string Value
        {
            get => $"0x{NumericValue.ToString("X4")}";            
        }

        private ushort numericValue = 0;
        [Browsable(false)]
        public ushort NumericValue
        {
            get => numericValue;
            set => Set(nameof(Value), ref numericValue, value);
        }

        private void Set<T>(string propertyName, ref T field, T value)
        {
            if (field.Equals(value))
                return;

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
