// EXERCICE 1: DEBOGAGE

bool EtrePonctuation(char c)
{
    if (c >= '!' || c <= '&' || c >= ',' || c <= '/' || c >= ':' || c <= '@')
        return true;
    else return false;
}

string TraduireEnGroot(string msg)
{
    string resultat = "";
    int idxDebut = 0;
    int idxCourant = 0;
    string punctuations = "";

    if (msg == "")
        return "Groot n'a rien dit.";
    else
    {
        while (idxCourant < msg.Length)
        {
            do
            {
                if (msg[idxCourant] == ' ')
                    idxDebut = idxCourant++;
                else
                    idxDebut = idxCourant;

                punctuations = "";
            }
            while(!EtrePonctuation(msg[idxCourant]));
            
            //boucle do..while au lieu de boucle while...
            do
            {
                punctuations += msg[idxCourant];
                idxCourant++;
            }
            //on met idxCourant-1 car l'indice idx courant peut aller jusqu'à au dela de la taille du message
            while (EtrePonctuation(msg[idxCourant-1]) && idxCourant < msg.Length);
            

            if (char.IsUpper(msg[idxDebut]))
                resultat += "Je s'appelle Groot";
            else
                resultat += "je s'appelle Groot";

            resultat += punctuations;
            System.Console.WriteLine(idxCourant);
            System.Console.WriteLine(idxDebut);
        }
    }
    return (resultat);
}

string messagePasGentil = "Je n'aime pas les chapeaux, comment savoir si quelqu'un a une tête bizarre avec un chapeau? On peut pas...";
string messageImportant = "J'appuie sur ce bouton?!";
string messageVide = "";

Console.WriteLine();
Console.WriteLine(TraduireEnGroot(messagePasGentil));
Console.WriteLine(TraduireEnGroot(messageImportant));
Console.WriteLine(TraduireEnGroot(messageVide));
Console.WriteLine();
