using System;
using System.Collections.Generic;

class Recipe
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public string Instructions { get; set; }
    public int PrepTime { get; set; }
}

class Program
{
    static List<Recipe> recipes = new List<Recipe>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Recipe Book ===");
            Console.WriteLine("1.Add Recipe 2.View All 3.Search 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Recipe Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Prep Time (mins): ");
                    int time = int.Parse(Console.ReadLine());
                    Console.Write("Ingredients (comma separated): ");
                    string[] ing = Console.ReadLine().Split(',');
                    Console.Write("Instructions: ");
                    string instr = Console.ReadLine();
                    recipes.Add(new Recipe
                    {
                        Name = name,
                        PrepTime = time,
                        Ingredients = new List<string>(ing),
                        Instructions = instr
                    });
                    Console.WriteLine("Recipe saved!");
                    break;

                case 2:
                    foreach (var r in recipes)
                    {
                        Console.WriteLine($"\n{r.Name} ({r.PrepTime} mins)");
                        Console.WriteLine("Ingredients: " + string.Join(", ", r.Ingredients));
                        Console.WriteLine(r.Instructions);
                    }
                    break;

                case 3:
                    Console.Write("Search: ");
                    string search = Console.ReadLine();
                    foreach (var r in recipes.FindAll(x => x.Name.Contains(search)))
                    {
                        Console.WriteLine($"\n{r.Name} ({r.PrepTime} mins)");
                        Console.WriteLine("Ingredients: " + string.Join(", ", r.Ingredients));
                        Console.WriteLine(r.Instructions);
                    }
                    break;

                case 4:
                    return;
            }
        }
    }
}