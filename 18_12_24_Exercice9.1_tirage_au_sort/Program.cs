using System;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables :
            List<String> listeDesNomsRestants = new List<string> { "Michel Platini", "Michel Sardou", "Michel Drucker", "Michel Houellebecq", "Michel Rocard", "Michelle Pfeiffer", "Michel Blanc", "Michelangelo", "Michelle Obama", "Michel Denisot", "Michèle Bernier", "Michèle Mercier", "Michèle Torr", "Michel Laroque", "Michel Cazenave", "Michel Chevalet", "Michel Ocelot", "Michel Petrucciani", "Michel Barnier", "Michel Peissel", "Michel Guérard", "Michel Signoli", "Michel Lévêque", "Michel Dumas", "Michel Vauzelle", "Michel Kachlouk", "Michel Bensoussan", "Michel Alberganti", "Michel Ardan", "Michel Fugain"};
            List<String> listeDesNomsTires = new List<string> { };
            int entreeUtilisateur = 0;
            Random aleatoire = new Random();
            int numeroTire = 0;
            
            do
            {//MENU PRINCIPAL :
                Console.Write("--- Le grand tirage au sort ---\n" +
                    "\n1 --- Effectuer un tirage" +
                    "\n2 --- Voir la  liste des personnes déjà tirées" +
                    "\n3 --- Voir la liste des personnes restantes" +
                    "\n0 --- Quitter" +
                    "\n\n Faîtes votre choix : ");
                entreeUtilisateur = int.Parse(Console.ReadLine());

                switch (entreeUtilisateur)
                {
                    //TIRAGE :
                    case 1:
                        Console.Clear();
                        numeroTire = aleatoire.Next(0, listeDesNomsRestants.Count);//<--Tirage d'un nombre aléatoire qui servira d'index.
                        Console.ForegroundColor = ConsoleColor.Blue;
                        String annonceDuGagnant = $"║ Le.a gagnant.e est {listeDesNomsRestants[numeroTire]} ! ║";

                        //Affichage du gagnant avec un encadrée:
                        Console.Write("╔");
                        for (int i = 0; i < annonceDuGagnant.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╗");
                        Console.WriteLine(annonceDuGagnant);
                        Console.Write("╚");
                        for (int i = 0; i < annonceDuGagnant.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╝");
                        Console.ResetColor();

                        listeDesNomsTires.Add(listeDesNomsRestants[numeroTire]);//<--Ajout à la liste des noms tirés.
                        listeDesNomsRestants.Remove(listeDesNomsRestants[numeroTire]);//<--Suppression de la liste des noms restants.
                    break;

                    //LISTE DES PERSONNES TIRÉES:
                    case 2:
                        //Affichage du titre "Liste des personnes tirées" avec encadré:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        String titreListeDesPersonnsTirées = "║ Liste des personnes tirées ║";
                        Console.Write("╔");
                        for (int i = 0; i < titreListeDesPersonnsTirées.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╗");
                        Console.WriteLine(titreListeDesPersonnsTirées);
                        Console.Write("╚");
                        for (int i = 0; i < titreListeDesPersonnsTirées.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╝");
                        Console.ResetColor();

                        //Affichage de la liste :
                        for (int i = 0; i < listeDesNomsTires.Count; i++) //<--Défilement de la liste des personnes tirées.
                        {
                            for (int j = 0; j < i; j++)//<--Affichage des tabulations pour l'affichage de la liste en diagonal.
                            {
                                Console.Write("  ");
                            }
                            Console.WriteLine(listeDesNomsTires[i]);
                        }
                        Console.WriteLine("\n");
                    break;

                    //LISTE DES PERSONNES RESTANTES:
                    case 3:
                        //Affichage du titre "Liste des personnes restantes" avec encadré:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        String titreListeDesPersonnesRestantes = "║ Liste des personnes restantes ║";
                        Console.Write("╔");
                        for (int i = 0; i < titreListeDesPersonnesRestantes.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╗");
                        Console.WriteLine(titreListeDesPersonnesRestantes);
                        Console.Write("╚");
                        for (int i = 0; i < titreListeDesPersonnesRestantes.Length - 2; i++)
                        {
                            Console.Write("═");
                        };
                        Console.WriteLine("╝");
                        Console.ResetColor();

                        //Affichage de la liste :
                        for (int i = 0; i < listeDesNomsRestants.Count; i++)//<--Défilement de la liste des personnes restantes.
                        {
                            for(int j = 0; j < i; j++)//<--Affichage des tabulations pour l'affichage de la liste en diagonal.
                            {
                                Console.Write("  ");
                            }
                            Console.WriteLine(listeDesNomsRestants[i]);
                        }
                        Console.WriteLine("\n");
                    break;

                    //SORTIE DU PROGRAMME:
                    case 0:
                        Environment.Exit(0);
                    break;
                }
            } while (true);

        }
    }
}