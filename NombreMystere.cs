// Trouve le nombre mystere 

string? readResult;
string entreeUtilisateur = "";
int nbUtilisateur = 0;
int compteur = 0;

do
{
    Console.Clear();
    Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
    Console.WriteLine("Choisis ton mode de jeu en tapant le numéro:");
    Console.WriteLine("1- Trouve le nombre mystère entre 1 et 999.");
    Console.WriteLine("2- Trouve le nombre mystère entre 1 et 9 999.");
    Console.WriteLine("3- Trouve le nombre mystère entre 1 et 99 999.");
    Console.WriteLine("4- Trouve le nombre mystère entre 1 et 999 999.");
    Console.WriteLine("0- Quitter");

    readResult = Console.ReadLine();
    if (readResult != null)
        entreeUtilisateur = readResult;

    switch (entreeUtilisateur)
    {
        case "0":
            break;

        case "1":
            Random nbAleatoire = new Random();
            int nbMystere = nbAleatoire.Next(1, 1000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
                Console.WriteLine("Trouve le nombre mystère entre 1 et 999.");
                Console.WriteLine("Je te dirai si c'est plus ou moins!");
                Console.WriteLine("A toi de jouer...\n ");
                //Console.WriteLine("Nombre mystère = " + nbMystere);

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        entreeUtilisateur = readResult;
                        compteur++;
                    }


                    bool validNumber = false;
                    validNumber = int.TryParse(entreeUtilisateur, out nbUtilisateur);
                    if (validNumber == false)
                    {
                        Console.WriteLine("Entre un nombre, pas des lettres!");
                        continue;
                    }

                    if (nbUtilisateur < 1 || nbUtilisateur > 999)
                    {
                        Console.WriteLine("Ton nombre n'est pas compris entre 1 et 999");
                        continue;
                    }

                    if (nbUtilisateur < nbMystere)
                        Console.WriteLine("C'est plus!\n");

                    if (nbUtilisateur > nbMystere)
                        Console.WriteLine("C'est moins!\n");

                } while (nbUtilisateur != nbMystere);
                Console.WriteLine($"BRAVO! Tu as trouvé le nombre mystère en {compteur} coups!");
                readResult = Console.ReadLine();
                return;

            } while (entreeUtilisateur != "0" && nbUtilisateur != nbMystere);

        case "2":
            Random nbAleatoire2 = new Random();
            int nbMystere2 = nbAleatoire2.Next(1, 10000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
                Console.WriteLine("Trouve le nombre mystère entre 1 et 9 999.");
                Console.WriteLine("Je te dirai si c'est plus ou moins!");
                Console.WriteLine("A toi de jouer...\n ");
                //Console.WriteLine("Nombre mystère = " + nbMystere2);

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        entreeUtilisateur = readResult;
                        compteur++;
                    }

                    bool validNumber = false;
                    validNumber = int.TryParse(entreeUtilisateur, out nbUtilisateur);
                    if (validNumber == false)
                    {
                        Console.WriteLine("Entre un nombre, pas des lettres!");
                        continue;
                    }

                    if (nbUtilisateur < 1 || nbUtilisateur > 9999)
                    {
                        Console.WriteLine("Ton nombre n'est pas compris entre 1 et 9 999");
                        continue;
                    }

                    if (nbUtilisateur < nbMystere2)
                        Console.WriteLine("C'est plus!\n");

                    if (nbUtilisateur > nbMystere2)
                        Console.WriteLine("C'est moins!\n");

                } while (nbUtilisateur != nbMystere2);
                Console.WriteLine($"BRAVO! Tu as trouvé le nombre mystère en {compteur} coups!");
                readResult = Console.ReadLine();
                return;

            } while (entreeUtilisateur != "0" && nbUtilisateur != nbMystere2);


        case "3":
            Random nbAleatoire3 = new Random();
            int nbMystere3 = nbAleatoire3.Next(1, 100000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
                Console.WriteLine("Trouve le nombre mystère entre 1 et 99 999.");
                Console.WriteLine("Je te dirai si c'est plus ou moins!");
                Console.WriteLine("A toi de jouer...\n ");
                //Console.WriteLine("Nombre mystère = " + nbMystere3);

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        entreeUtilisateur = readResult;
                        compteur++;
                    }

                    bool validNumber = false;
                    validNumber = int.TryParse(entreeUtilisateur, out nbUtilisateur);
                    if (validNumber == false)
                    {
                        Console.WriteLine("Entre un nombre, pas des lettres!");
                        continue;
                    }

                    if (nbUtilisateur < 1 || nbUtilisateur > 99999)
                    {
                        Console.WriteLine("Ton nombre n'est pas compris entre 1 et 99 999");
                        continue;
                    }

                    if (nbUtilisateur < nbMystere3)
                        Console.WriteLine("C'est plus!\n");

                    if (nbUtilisateur > nbMystere3)
                        Console.WriteLine("C'est moins!\n");

                } while (nbUtilisateur != nbMystere3);
                Console.WriteLine($"BRAVO! Tu as trouvé le nombre mystère en {compteur} coups!");
                readResult = Console.ReadLine();
                return;

            } while (entreeUtilisateur != "0" && nbUtilisateur != nbMystere3);

        case "4":
            Random nbAleatoire4 = new Random();
            int nbMystere4 = nbAleatoire4.Next(1, 1000000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
                Console.WriteLine("Trouve le nombre mystère entre 1 et 999 999.");
                Console.WriteLine("Je te dirai si c'est plus ou moins!");
                Console.WriteLine("A toi de jouer...\n ");
                //Console.WriteLine("Nombre mystère = " + nbMystere4);

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        entreeUtilisateur = readResult;
                        compteur++;
                    }

                    bool validNumber = false;
                    validNumber = int.TryParse(entreeUtilisateur, out nbUtilisateur);
                    if (validNumber == false)
                    {
                        Console.WriteLine("Entre un nombre, pas des lettres!");
                        continue;
                    }

                    if (nbUtilisateur < 1 || nbUtilisateur > 999999)
                    {
                        Console.WriteLine("Ton nombre n'est pas compris entre 1 et 999 999");
                        continue;
                    }

                    if (nbUtilisateur < nbMystere4)
                        Console.WriteLine("C'est plus!\n");

                    if (nbUtilisateur > nbMystere4)
                        Console.WriteLine("C'est moins!\n");

                } while (nbUtilisateur != nbMystere4);
                Console.WriteLine($"BRAVO! Tu as trouvé le nombre mystère en {compteur} coups!");
                readResult = Console.ReadLine();
                return;

            } while (entreeUtilisateur != "0" && nbUtilisateur != nbMystere4);

        default:
            break;
    }

} while (entreeUtilisateur != "0");