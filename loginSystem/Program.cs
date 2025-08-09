using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Login
{

    static void Main()
    { 
        Console.WriteLine("Scegli un'opzione:");
        Console.WriteLine("1. Registrazione");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Esci");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Registration();
                break;
            case "2":
                LoginUser();
                break;
            case "3":
                Console.WriteLine("Uscita dal programma.");
                break;
            default:
                Console.WriteLine("Opzione non valida, riprova.");
                Main();
                break;
        }
    }
    static void Registration()
    {
        string username;
        string password;

        Console.WriteLine("Per registrarti inserisci il tuo nome utente");
        username = Console.ReadLine();

        Console.WriteLine("Per registrarti inserisci la tua password");
        password = Console.ReadLine();

        Console.WriteLine("Registrazione completata con successo!");
    }

    static void LoginUser()
    {
        string username;
        string password;

        Console.WriteLine("Per effettuare il login inserisci il tuo nome utente");
        username = Console.ReadLine();

        Console.WriteLine("Per effettuare il login inserisci la tua password");
        password = Console.ReadLine();

        Console.WriteLine("Login effettuato con successo!");
    }
}
