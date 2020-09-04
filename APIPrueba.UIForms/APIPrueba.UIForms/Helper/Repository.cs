using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Net.Http;
using APIPrueba.UIForms.Models;
using System.Net;

namespace APIPrueba.UIForms.Helper
{
    public class Repository
    {
        HttpClient client;

        public ObservableCollection<Product> Items
        {
            get; private set;
        }

        public Repository()
        {
            client = new HttpClient();
        }

        public HttpClient Client { get => client; set => client = value; }

        public async Task<ObservableCollection<Product>> RefreshDataAsync()
        { 
            var uri = new Uri(WebApiService.WebApiURL);
            try
            {
                var response = await Client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<ObservableCollection<Product>>(content);
                    return Items;
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public async Task<ObservableCollection<Product>> GetProductosByIdAsync(int id)
        {
            var uri = new Uri(WebApiService.WebApiURL + id);
            try
            {
                HttpClient client = new HttpClient();
                var response = await Client.GetAsync(uri);
                var jsonstring = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Product>>(jsonstring);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ObservableCollection<Product>> UpdateDataAsync(Product product)
        {
            var uri = new Uri(WebApiService.WebApiURL);
            try
            {
                string jsonData = JsonConvert.SerializeObject(product);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                
                HttpResponseMessage response = null;
                
                response = await client.PostAsync(uri, content);
                
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public async Task<HttpStatusCode> UpdateProducto(int id, Product producto)
        {
            var uri = new Uri(WebApiService.WebApiURL + id);
            try
            {
                HttpClient client = new HttpClient();
                var _producto = JsonConvert.SerializeObject(producto);
                var response = await client.PutAsync(uri, new StringContent(_producto, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    return HttpStatusCode.OK;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }

        public async Task<HttpStatusCode> DeleteProductoAsync(int? id)
        {
            var uri = new Uri(WebApiService.WebApiURL + id);
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.DeleteAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    return HttpStatusCode.OK;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
    }
}
