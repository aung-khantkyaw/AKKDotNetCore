﻿// See https://aka.ms/new-console-template for more information
using AKKDotNetCore.ConsoleAppHttpClientExample;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

/* HttpClient client = new HttpClient();
var response = await client.GetAsync("https://localhost:7126/api/blog");

if (response.IsSuccessStatusCode)
{
    string jsonStr = await response.Content.ReadAsStringAsync();
    Console.WriteLine(jsonStr);
    List<BlogDto> lst = JsonConvert.DeserializeObject<List<BlogDto>>(jsonStr)!;
    foreach (var blog in lst)
    {
        Console.WriteLine(JsonConvert.SerializeObject(blog));
    }
} */

HttpClientExample httpClientExample = new HttpClientExample();
await httpClientExample.RunAsync();
