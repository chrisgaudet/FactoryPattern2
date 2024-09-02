namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("Which database would you like to work with?");
                Console.WriteLine("Type: SQL");
                Console.WriteLine("Type: Mongo");
                Console.WriteLine("Type: List");


                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Choice!");
                    Thread.Sleep(1000);
                }
            } while (!correctInput); ;

            Console.Clear ();

            var db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
        }
    }
}
