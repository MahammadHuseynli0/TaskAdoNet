using AdoNetTask.Controllers;

namespace AdoNetTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte choice;
            ProductControllerr productController = new ProductControllerr();

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Create product\n2.Delete product\n3.Get a product\n4.Get all products\n5.Update product\n0.Exit");
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        productController.AddProduct();
                        break;


                    case 2:
                        productController.DeleteProduct();

                        break;


                    case 3:
                        productController.GetProduct();
                        break;

                    case 4:
                        productController.GetAllProducts();
                        break;

                    case 5:
                        productController.UpdateProduct();
                        break;

                }
            } while (choice != 0 );
        }
    }
}
