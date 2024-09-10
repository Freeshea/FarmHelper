using FarmHelper.Commands;
using FarmHelper.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace FarmHelper.ViewModel
{
    public class FarmViewModel : INotifyPropertyChanged
    {
        private FarmCalculator calculator;
        private int runCount;
        private double currentProbability;
        public ICommand AddRunCommand { get; set; }

        public FarmViewModel()
        {
            calculator = new FarmCalculator(1, 10); // Default drop chance and mobs per run
            AddRunCommand = new RelayCommand(AddRun, CanAddRun);
        }

        private bool CanAddRun(object obj)
        {
            return true;
        }

        public double DropChanceProp
        {
            get => calculator.dropChance;
            set
            {
                if(value < 0.01) value = 0.01;
                if(value > 100) value = 100;

                if(calculator.dropChance != value)
                {
                    calculator.dropChance = value;
                    ResetCalculator();
                    OnPropertyChanged(nameof(DropChanceProp));
                }
            }
        }

        public int MobCountProp
        {
            get => calculator.mobCount;
            set
            {
                if(value < 1) value = 1;
                if(value > 200) value = 200;

                if(calculator.mobCount != value)
                {
                    calculator.mobCount = value;
                    ResetCalculator();
                    OnPropertyChanged(nameof(MobCountProp));
                }
            }
        }

        public int RunCountProp
        {
            get => runCount;
            private set
            {
                runCount = value;
                OnPropertyChanged(nameof(RunCountProp));
            }
        }

        public double CurrentProbabilityProp
        {
            get => currentProbability;
            private set
            {
                currentProbability = value;
                OnPropertyChanged(nameof(CurrentProbabilityProp));
            }
        }


        private void AddRun(object obj)
        {
            RunCountProp++;
            CurrentProbabilityProp = calculator.CalculateProbability(RunCountProp);
        }

        private void ResetCalculator()
        {
            RunCountProp = 0;
            CurrentProbabilityProp = 0;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
