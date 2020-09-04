using APIPrueba.UIForms.Helper;
using APIPrueba.UIForms.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace APIPrueba.UIForms.ViewModels
{
    public class UpdateProductViewModel: INotifyPropertyChanged
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
        public UpdateProductViewModel()
        {
            webAPIService = new Repository();

            items = new ObservableCollection<Product>();
        }
        #endregion

        #region Methods 
        async void UpdateData()
        {
            var products = new Product
            {
                id = ID,
                nameproduct = nameProduct,
                codebar = codeBar,
                description = descProduct,
                stock = stockProduct,
                imgitem = imgProduct
            };
            Items = await webAPIService.UpdateDataAsync(products);

        }
        public Command UpdateProductCommand
        {
            get
            {
                return new Command(() =>
                {
                    UpdateData();
                });
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
