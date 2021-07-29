using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {

        //OPEN CLOSE

        static void Main(string[] args)

        {
            /*ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }  */

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                //Console.WriteLine(product.ProductName);
            }

            foreach (var prd in productManager.GetAllByCategoryId(5))
            {
                //Console.WriteLine(prd.ProductName);
            }

            foreach (var prd in productManager.GetByUnitPrice(15, 50))
            {
                Console.WriteLine(prd.ProductName);
            }
        }
    }
}
