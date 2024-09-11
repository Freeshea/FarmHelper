using FarmHelper.Commands;
using FarmHelper.Model;
using FarmHelper.View;
using System.ComponentModel;
using System.Windows.Input;

namespace FarmHelper.ViewModel
{
    public class FarmViewModel : INotifyPropertyChanged
    {
        private FarmCalculator calculator;
        private int runCount;
        private double currentProbability;
        private int requiredRuns;
        public ICommand AddRunCommand { get; set; }
        public ICommand HelpWindowCommand {  get; set; }

        public FarmViewModel()
        {
            calculator = new FarmCalculator(1, 10); // Default drop chance and mobs per run
            AddRunCommand = new RelayCommand(AddRun, CanAddRun);
            HelpWindowCommand = new RelayCommand(HelpWindow, CanHelpWindow);
            UpdateRequiredRuns();
        }

        private bool CanAddRun(object obj)
        {
            return true;
        }
        private bool CanHelpWindow(object obj)
        {
            return true;
        }

        public int RequiredRunsProp
        {
            get => requiredRuns;
            set
            {
                requiredRuns = value;
                OnPropertyChanged(nameof(RequiredRunsProp));
            }
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
                    UpdateRequiredRuns();
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
                    UpdateRequiredRuns();
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

        private void UpdateRequiredRuns()
        {
            RequiredRunsProp = calculator.CalculateRequiredRuns(0.9); // Calculate necessary runs for at least 90% probability
        }
        private void AddRun(object obj)
        {
            RunCountProp++;
            CurrentProbabilityProp = calculator.CalculateProbability(RunCountProp);
        }

        private void HelpWindow(object obj)
        {
            HelpWindow helpWindow = FarmHelper.View.HelpWindow.GetInstance();
            helpWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            helpWindow.Show();
            helpWindow.Activate();
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
