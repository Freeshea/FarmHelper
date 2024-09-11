using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FarmHelper.View
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        private static HelpWindow _instance;

        public HelpWindow()
        {
            InitializeComponent();
        }

        public static HelpWindow GetInstance()  // Singleton
        {
            if(_instance == null || !_instance.IsVisible)
            {
                _instance = new HelpWindow();
            }
            return _instance;
        }

    }
}
