using APIPrueba.UIForms.Helper;
using APIPrueba.UIForms.Models;
using APIPrueba.UIForms.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace APIPrueba.UIForms.ViewModels
{
    public class GetProductsViewModel : INotifyPropertyChanged
    {
        #region Fields

        Repository webAPIService;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Product> items;
        private Product selectedProduct;

        #endregion

        #region Properties
        public ObservableCollection<Product> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                RaisepropertyChanged("Items");
            }
        }

        
        public Product SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
                if (value != null)
                {
                    App.Current.MainPage.Navigation.PushAsync(new EditProductView(SelectedProduct));
                }
                RaisepropertyChanged("SelectedProduct");
            }
        }
        #endregion

        #region Constructor
        public GetProductsViewModel()
        {
            webAPIService = new Repository();

            items = new ObservableCollection<Product>();
            GetData();
        }
        #endregion

        #region Methods 
        async void GetData()
        {
            Items = await webAPIService.RefreshDataAsync();
        }
        void RaisepropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
