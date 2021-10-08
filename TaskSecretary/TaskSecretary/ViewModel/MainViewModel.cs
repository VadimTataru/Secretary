using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TaskSecretary.View;

namespace TaskSecretary.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page home = new HomePage();
        private Page task = new TaskPage();
        private Page shop = new ShopPage();
        private Page cook = new CookPage();
        private Page expenses = new ExpensesPage();
        private Page currentPage = new HomePage();

        public Page CurrentPage
        {
            get => currentPage;
            set => Set(ref currentPage, value);
        }

        public ICommand OpenHomePage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = home);
            }
        }

        public ICommand OpenTaskPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = task);
            }
        }

        public ICommand OpenShopPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = shop);
            }
        }

        public ICommand OpenCookPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = cook);
            }
        }

        public ICommand OpenExpencesPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = expenses);
            }
        }
    }
}
