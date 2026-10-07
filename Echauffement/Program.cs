namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("Je suis Emilien! Mon jeu préféré est Subnautica.");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("Quel est votre prénom et votre âge?\n");
        string prenom = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bienvenue "+prenom+"! Tu as donc "+age+ " ans.\n");

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        if (age >= 18)
            {
            Console.WriteLine("Tu es majeur!\n");
        }
        else
        {
            Console.WriteLine("Tu es mineur!");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("Combien d'euros as-tu?");
        float euros = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Tu as donc "+euros+" euros.");

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("Tu as 4 choix d'armes à acheter:\n");
        Console.WriteLine("1. Un tomahawk à 100 euros.");
        Console.WriteLine("2. Un revolver à 250 euros.");
        Console.WriteLine("3. Un Fusil à pompe à 500 euros.");
        Console.WriteLine("4. Un Pistolet Mauser à 1000 euros.\n");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Choisis ton arme en idiquant son numéro.\n");
        int choix = Convert.ToInt32(Console.ReadLine());

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        if (choix == 1)
        {
            if (euros >= 100f && age >= 18)
            {
                euros -= 100;
                Console.WriteLine("Tu as bien acheté le Tomahawk, il te reste "+euros+" euros.");
            }
            else
            {
                Console.WriteLine("Tu n'as pas assez d'euros ou tu n'est pas majeur.");
            }
        }
        else if (choix == 2)
        {
            if (euros >= 250f && age >= 18)
            {
                euros -= 250;
                Console.WriteLine("Tu as bien acheté le Revolver, il te reste " + euros + " euros.");
            }
            else
            {
                Console.WriteLine("Tu n'as pas assez d'euros ou tu n'est pas majeur.");
            }
        }
        else if (choix == 3)
        {
            if (euros >= 500f && age >= 18)
            {
                euros -= 500;
                Console.WriteLine("Tu as bien acheté le Fusil à pompe, il te reste " + euros + " euros.");
            }
            else
            {
                Console.WriteLine("Tu n'as pas assez d'euros ou tu n'est pas majeur.");
            }
        }
        else if (choix == 4)
        {
            if (euros >= 1000f && age >= 18)
            {
                euros -= 1000;
                Console.WriteLine("Tu as bien acheté le Pistolet Mauser, il te reste " + euros + " euros.");
            }
            else
            {
                Console.WriteLine("Tu n'as pas assez d'euros ou tu n'est pas majeur.");
            }
        }
        else if (choix >= 5)
        {
            Console.WriteLine("Ce choix n'est pas correct.");
        }

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
        
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}