using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;

namespace LeaveAppWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            UserName = Environment.UserName;
            CurrentView = ViewModelLocator.DashboardVM;
            GoToAskLeave = new RelayCommand(AskLeaveGoTo);
            GoToDashboard = new RelayCommand(DashboardGoTo);
            GoToMyLeave = new RelayCommand(MyLeaveGoTo);
            
        }


        #region Methodes
        private void MyLeaveGoTo()
        {
            InitAll();
            CurrentView = ViewModelLocator.MyLeaveVM;
        }

        private void DashboardGoTo()
        {
            InitAll();
            CurrentView = ViewModelLocator.DashboardVM;
        }

        private void AskLeaveGoTo()
        {
            InitAll();
            CurrentView = ViewModelLocator.AskLeaveVM;
        }

        public void InitAll()
        {
            SimpleIoc.Default.Unregister<DashboardViewModel>();
            SimpleIoc.Default.Unregister<MyLeaveViewModel>();
            SimpleIoc.Default.Unregister<AskLeaveViewModel>();
            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<MyLeaveViewModel>();
            SimpleIoc.Default.Register<AskLeaveViewModel>();
        }
        #endregion

        #region Variables locales
        private ViewModelBase _currentView;
        private string _username;
        #endregion


        #region Arguments
        public ICommand GoToAskLeave { get; set; }
        public ICommand GoToMyLeave { get; set; }
        public ICommand GoToDashboard{ get; set; }

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged(()=>UserName);
            }
        }

        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                RaisePropertyChanged(() => CurrentView);
            }
        }
        #endregion
    }
}