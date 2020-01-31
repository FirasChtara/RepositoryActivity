namespace EnumExemple
{
    [Flags]
    enum Couleur : int
    {
        rouge = 1,
        vert = 2,
        bleu = 4
    };
    class Program
    {
        static void Main(string[] args)
        {
            Couleur maCouleur = Couleur.rouge | Couleur.bleu;
            Console.WriteLine("La couleur courante est : {0} ", maCouleur.ToString());
        }
    }
}