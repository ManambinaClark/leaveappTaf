using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;


namespace LeaveAppWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the LoginViewModel class.
        /// </summary>
        /// 
        public MainWindow main;
        public LoginViewModel()
        {
            Connect = new RelayCommand(Connexion);
        }

        private void Connexion()
        {
            main = new MainWindow();
            main.Show();

        }

        public ICommand Connect { get; set; }
    }
}