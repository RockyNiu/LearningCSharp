using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFacoty productFactory = new ProductFacoty();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);
            Logger logger = new Logger();
            Action<Product> action = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1, action);
            Box box2 = wrapFactory.WrapProduct(func2, action);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toyCarFactory = new ToyCarFactory();

            Box box3 = wrapFactory.WrapProduct_2(pizzaFactory);
            Box box4 = wrapFactory.WrapProduct_2(toyCarFactory);

            Console.WriteLine(box3.Product.Name);
            Console.WriteLine(box4.Product.Name);
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product; throw new NotImplementedException();
        }
    }


    class Logger
    { 
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}. Price is {2}.", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallBack)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price >= 50)
            {
                logCallBack(product);
            }
            box.Product = product;
            return box;
        }

        public Box WrapProduct_2(IProductFactory iProductFactory)
        {
            Box box = new Box();
            Product product = iProductFactory.Make();
            box.Product = product;
            return box;
        }
    }

    class ProductFacoty
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }

 
}