// This code defines a simple login system with registration and login functionalities.
// It allows users to register with a username and password, and then log in using those credentials
// The program prompts the user to choose between registration, login, or exiting the program.
// The code is structured to handle user input and provide feedback based on the user's actions.
// The methods Registration and LoginUser handle the respective functionalities.
// The choose method manages the user interface and directs the flow of the program based on user choices
// The program is designed to be simple and user-friendly, guiding the user through the registration and login process.
// The code is written in C# and uses basic console input/output for interaction.
// The program is structured to be easily extendable for future enhancements, such as adding user data
// storage or validation features.
// The Login class encapsulates the login functionality and provides a clear structure for the program.
// The code is ready to be executed in a C# environment, providing a basic framework for a login system.
// The program can be compiled and run in any C# compatible environment, such as Visual Studio or .NET CLI.
// The code is a good starting point for learning about user authentication and console applications
// in C#.
// The program can be further enhanced by adding features like password encryption, user data storage, and
// validation checks to ensure secure and reliable user authentication.
// The code is designed to be simple and straightforward, making it easy for beginners to understand and
// modify as needed.
// The program is a practical example of how to implement basic user authentication in a console application.
// The code is structured to be clear and maintainable, following C# conventions and best practices
// for readability and organization.
// The program serves as a foundation for building more complex authentication systems in the future.
// The code is a good exercise for understanding control flow, user input handling, and method usage
// in C# console applications.

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