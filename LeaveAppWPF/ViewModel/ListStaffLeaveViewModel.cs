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
    public class ListStaffLeaveViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the ListStaffLeaveViewModel class.
        /// </summary>
        public ListStaffLeaveViewModel()
        {
            GoBack = new RelayCommand(GoDashboard);
        }

        #region Methodes
        private void GoDashboard()
        {
            ViewModelLocator.Main.CurrentView = ViewModelLocator.DashboardVM;
        }
        #endregion

        #region Arguments
        public ICommand GoBack { get; set; }

        #endregion
    }
}