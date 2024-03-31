// Trouve le nombre mystere 

string? readResult;
string entreeUtilisateur = "";
int nbMystere = 0;
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
            NumeroMystere(999);
            break;

        case "2":
            NumeroMystere(9999);
            break;


        case "3":
            NumeroMystere(99999);
            break;

        case "4":
            NumeroMystere(999999);
            break;
    }

} while (entreeUtilisateur != "0" && entreeUtilisateur != "stop" && nbMystere != nbUtilisateur);


void NumeroMystere(int nbMax)
{
    Random nbAleatoire = new Random();
    nbMystere = nbAleatoire.Next(1, nbMax);

    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenue dans \"Le nombre Mystère\"");
        Console.WriteLine($"Trouve le nombre mystère entre 1 et {nbMax:N0}.");
        Console.WriteLine("Je te dirai si c'est plus ou moins!");
        Console.WriteLine("Ecris stop pour arréter.");
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

            if (entreeUtilisateur == "stop")
                return;

            bool validNumber = false;
            validNumber = int.TryParse(entreeUtilisateur, out nbUtilisateur);
            if (validNumber == false)
            {
                Console.WriteLine("Entre un nombre, pas des lettres!\n");
                compteur--;
                continue;
            }

            if (nbUtilisateur < 1 || nbUtilisateur > nbMax)
            {
                Console.WriteLine($"Ton nombre n'est pas compris entre 1 et {nbMax:N0}");
                compteur--;
                continue;
            }

            if (nbUtilisateur < nbMystere)
                Console.WriteLine("C'est plus!\n");

            if (nbUtilisateur > nbMystere)
                Console.WriteLine("C'est moins!\n");

        } while (nbUtilisateur != nbMystere && entreeUtilisateur != "stop");

        Console.WriteLine($"BRAVO! Tu as trouvé le nombre mystère en {compteur} coups!");
        readResult = Console.ReadLine();
        return;

    } while (nbUtilisateur != nbMystere);
}
