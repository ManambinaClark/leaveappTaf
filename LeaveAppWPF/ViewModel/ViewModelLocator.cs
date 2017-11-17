/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:LeaveAppWPF"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace LeaveAppWPF.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NewStaffViewModel>();
            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<MyLeaveViewModel>();
            SimpleIoc.Default.Register<AskLeaveViewModel>();
            SimpleIoc.Default.Register<ListStaffViewModel>();


        }

        public static ListStaffViewModel ListStaffVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListStaffViewModel>();
            }
        }

        public static AskLeaveViewModel AskLeaveVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AskLeaveViewModel>();
            }
        }

        public static MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static MyLeaveViewModel MyLeaveVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyLeaveViewModel>();
            }
        }

        public static DashboardViewModel DashboardVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DashboardViewModel>();
            }
        }
        public static NewStaffViewModel NewStaffVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NewStaffViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}