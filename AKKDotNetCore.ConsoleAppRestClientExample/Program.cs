// See https://aka.ms/new-console-template for more information
using AKKDotNetCore.ConsoleAppRestClientExample;

Console.WriteLine("Hello, World!");

RestClientExample restClientExample = new RestClientExample();
await restClientExample.RunAsync();

Console.ReadLine();