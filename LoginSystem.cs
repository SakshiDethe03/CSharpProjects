using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

class Program
{
    static List<User> users = new List<User>
    {
        new User { Username = "admin", Password = "admin123", Role = "Admin" }
    };

    static bool loggedIn = false;
    static string currentUser = "";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Login System ===");
            Console.WriteLine("1.Login 2.Register 3.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Username: ");
                    string user = Console.ReadLine();
                    Console.Write("Password: ");
                    string pass = Console.ReadLine();
                    var found = users.Find(u => u.Username == user && u.Password == pass);
                    if (found != null)
                    {
                        loggedIn = true;
                        currentUser = found.Username;
                        Console.WriteLine($"Welcome {found.Role}!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials!");
                    }
                    break;

                case 2:
                    Console.Write("Username: ");
                    string newUser = Console.ReadLine();
                    Console.Write("Password: ");
                    string newPass = Console.ReadLine();
                    Console.Write("Role (User/Admin): ");
                    string role = Console.ReadLine();
                    users.Add(new User { Username = newUser, Password = newPass, Role = role });
                    Console.WriteLine("Registered!");
                    break;

                case 3:
                    return;
            }
        }
    }
}