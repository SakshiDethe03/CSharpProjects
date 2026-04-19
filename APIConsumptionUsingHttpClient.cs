using System.Net.Http;

var client = new HttpClient();

var data = await client.GetStringAsync("https://api.github.com");

Console.WriteLine(data);