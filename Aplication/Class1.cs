using System;
using System.Collections.Generic;
using System.Linq;

namespace Godina
{
    public class Flower
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }

        public Flower(string title, string description, string owner)
        {
            Title = title;
            Description = description;
            Owner = owner;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {Title}, Description: {Description}, Owner: {Owner}");
        }
    }
}
namespace Godina
{
    public class Garden
    {
        public string Address { get; set; }
        public string Owner { get; set; }
        public List<Flower> Flowers { get; set; }

        public Garden(string address, string owner)
        {
            Address = address;
            Owner = owner;
            Flowers = new List<Flower>();
        }

        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }

        public void ShowAll()
        {
            Console.WriteLine($"Garden Address: {Address}, Owner: {Owner}");
            Console.WriteLine("Flowers in the garden:");
            foreach (var flower in Flowers)
            {
                flower.Show();
            }
        }
        public void ShowAllSortedByTitle()
        {
            Console.WriteLine($"Garden Address: {Address}, Owner: {Owner}");
            Console.WriteLine("Flowers in the garden (sorted by title):");
            var sortedFlowers = Flowers.OrderBy(f => f.Title);
            foreach (var flower in sortedFlowers)
            {
                flower.Show();
            }
        }
    }
}