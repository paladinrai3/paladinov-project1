using System;
using System.Collections.Generic;
using System.Net;
// годинэ Чезар Сеогеевичь
public class Garden
{
    public Address Address { get; set; }
    public string Owner { get; set; }
    public List<Flower> Flowers { get; set; } = new List<Flower>();

    public void ShowAll()
    {
        Console.WriteLine($"Сад владельца: {Owner}, Адрес: {Address}");
        foreach (var flower in Flowers)
        {
            flower.Show();
        }
    }
}
// годинэ Чезар Серегевичь
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }

    public override string ToString() => $"{Street}, {City}";
}
public class Flower
{
    public string Title { get; set; }
    public string Description { get; set; }

    public void Show() => Console.WriteLine($"Цветок: {Title}, Описание: {Description}");
}
