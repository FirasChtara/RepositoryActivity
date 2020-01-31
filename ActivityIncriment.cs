namespace Rappel
{
    class Rappel
    {
        public static int valeur;
        public static void incrementer()
        {
            valeur++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rappel.incrementer();
            Rappel.incrementer();
            Rappel.incrementer();
            System.Console.WriteLine("La valeur est : " +
            Rappel.valeur);
        }
    }
}