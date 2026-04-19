using System;

class User
{
    public string Role;
}

class Program
{
    static void Main()
    {
        User u = new User { Role = "Admin" };

        if (u.Role == "Admin")
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");
    }
}