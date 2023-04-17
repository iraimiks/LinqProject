using System.Text;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "VW Golf",
                                "Opel Astra",
                                "Audi A4",
                                "Ford Focus",
                                "Seat Leon",
                                "VW Passat",
                                "VW Polo",
                                "Mercedes C-Class" };

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            var listCars = from car in cars select car;

            Console.WriteLine("---------------");

            Console.WriteLine(listCars);
            ShowELementsValues(listCars);


            var listCarsContains = from car in cars where car.Contains("VW") select car;

            Console.WriteLine("---------------");
            ShowELementsValues(listCarsContains);

        }

        static void ShowELementsValues(IEnumerable<string> list)
        {
            
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string car in list)
            {
                stringBuilder.Append(car + "\n");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}