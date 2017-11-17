using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace LeaveAppWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class DashboardViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the DashboardViewModel class.
        /// </summary>
        public DashboardViewModel()
        {
            ViewStaff = new RelayCommand(StaffView);

        }
        #region Methodes
        private void StaffView()
        {
            ViewModelLocator.Main.CurrentView = ViewModelLocator.ListStaffVM;
        }
        #endregion


        #region Arguments
        public ICommand ViewStaff { get; set; }
        public ICommand ViewStaffLeave{ get; set; }
        public ICommand ViewReport { get; set; }
        #endregion


    }
}