using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCalculator2.ViewModels
{
    class CalculatorViewModel : ObservableObject
    {
        public ICommand ButtonCalculateCommand { get; set; }

        private double _result;

        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        private void PerformCalculation(object obj)
        {
            Result = 55; // value to confirm binding of property
        }

        public CalculatorViewModel()
        {
            Operand1 = 44; //value to confirm binding of property
            ButtonCalculateCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }
    }
}
