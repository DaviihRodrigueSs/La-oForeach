using System.Globalization;
namespace LaçoForeach
{
    class program
    {
        //utilizando o foreach
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);

            }
            Console.WriteLine("______________________________________");

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

        }
    }
}