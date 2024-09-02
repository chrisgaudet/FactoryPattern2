using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name = "Playstation 5", Price = 500},
            new Product (){ Name = "Xbox One", Price = 400},
            new Product (){ Name = "Nintendo Switch", Price = 300},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm reading data from List Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I'm saving data from List Data Access.");
        }
    }
}
