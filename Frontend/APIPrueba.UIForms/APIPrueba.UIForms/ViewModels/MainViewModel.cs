namespace APIPrueba.UIForms.ViewModels
{
    using ViewModels;
    public class MainViewModel
    {
        private static MainViewModel instace;
        public GetProductsViewModel getProduct {get;set;}
        public AddProductViewModel addProduct { get; set; }
        public UpdateProductViewModel updateProduct { get; set; }
        public DeleteProductViewModel deleteProduct { get; set; }

        public MainViewModel()
        {
            instace = this;
            this.getProduct = new GetProductsViewModel();
            this.addProduct = new AddProductViewModel();
            this.deleteProduct = new DeleteProductViewModel();
        }
        public static MainViewModel GetInstance()
        {
            if (instace==null)
            {
                return new MainViewModel();
            }

            return instace;
        }
    }
}
