using APIPrueba.UIForms.Helper;
using APIPrueba.UIForms.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace APIPrueba.UIForms.ViewModels
{
    public class DeleteProductViewModel : INotifyPropertyChanged
    {
        #region Fields

        Repository webAPIService;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Product> items;

        #endregion

        #region Properties

        private int ID;

        public int Id
        {
            get { return ID; }
            set
            {
                ID = value;
                RaisepropertyChanged("Id");
            }
        }

        private string nameProduct;

        public string NameProduct
        {
            get { return nameProduct; }
            set
            {
                nameProduct = value;
                RaisepropertyChanged("NameProduct");
            }
        }

        private int codeBar;

        public int CodeBar
        {
            get { return codeBar; }
            set
            {
                codeBar = value;
                RaisepropertyChanged("CodeBar");
            }
        }

        private string descProduct;

        public string DescProduct
        {
            get { return descProduct; }
            set
            {
                descProduct = value;
                RaisepropertyChanged("DescProduct");
            }
        }

        private int stockProduct;

        public int StockProduct
        {
            get { return stockProduct; }
            set
            {
                stockProduct = value;
                RaisepropertyChanged("StockProduct");
            }
        }
        private string imgProduct;

        public string ImgProduct
        {
            get { return imgProduct; }
            set
            {
                imgProduct = value;
                RaisepropertyChanged("ImgProduct");
            }
        }

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
        #endregion

        #region Constructor
        public DeleteProductViewModel()
        {
            webAPIService = new Repository();

            items = new ObservableCollection<Product>();
        }
        #endregion
        #region Commands

        public Command RemoveStockCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteData();
                });
            }
        }

        #endregion

        #region Methods 
    
        async void DeleteData()
        {
            var result = await webAPIService.DeleteProductoAsync(ID);
            if (result == HttpStatusCode.OK)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Producto Eliminado", "Aceptar");
            }

        }
        void RaisepropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
