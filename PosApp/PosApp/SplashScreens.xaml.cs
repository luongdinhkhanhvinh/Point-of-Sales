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
using System.ComponentModel;

namespace PosApp
{
    /// <summary>
    /// Interaction logic for splashScreens.xaml
    /// </summary>
    public partial class SplashScreens : Window
    {

        private BackgroundWorker _bgWorker = new BackgroundWorker();

        private int _workerState;

        public int WorkerState
        {
            get { return _workerState; }
            set
            {
                _workerState = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkerState"));
            }
        }
        public SplashScreens()
        {
            InitializeComponent();

            DataContext = this;

            _bgWorker.DoWork += (s, e) =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    WorkerState = i;
                }

                Application.Current.Dispatcher.Invoke((Action)delegate
                {
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                });
            };

        }

        #region INotifyPropertyChanged Member 
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
