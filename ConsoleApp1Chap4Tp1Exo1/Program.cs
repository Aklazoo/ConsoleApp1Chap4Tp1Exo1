namespace ConsoleApp1Chap4Tp1Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien coute votre arme ?");
            int prixArme = int.Parse(Console.ReadLine());

            //Taxe
            decimal taxeRoyaleStandard = 1.20m;
            decimal taxeMiniereSpeciale = 1.10m;
            decimal taxeReduiteImpor = 1.055m;
            decimal terreArtisanatBeni = 1.021m;
            
            //choix

            Console.WriteLine("D'où provient votre arme ? \n De la Forges de la Capitale ? \n De l'atelier des Nains des Montagnes ? \n Du port des Contrebandiers ? \n De la Terre Sacrées du Temple ? ");
            int choix = Convert.ToInt16(Console.ReadLine());

            switch (choix)
            {
                case 1: Console.WriteLine($"Le prix de votre arme est de {prixArme * taxeRoyaleStandard} pièces d'or"); break;
                case 2: Console.WriteLine($"Le prix de votre arme est de {prixArme * taxeMiniereSpeciale} pièces d'or"); break;
                case 3: Console.WriteLine($"Le prix de votre arme est de {prixArme * taxeReduiteImpor} pièces d'or"); break;
                case 4: Console.WriteLine($"Le prix de votre arme est de {prixArme * terreArtisanatBeni} pièces d'or"); break;


            }
                        
            
        }
    }
}
