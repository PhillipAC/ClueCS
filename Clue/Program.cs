using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clue.Controllers;
using Clue.Models;

namespace Clue
{
    class Program
    {

        private static CategoriesController _CategoriesController = new CategoriesController();
        private static CardsController _CardController = new CardsController();

        static void Main(string[] args)
        {
        
            _CategoriesController.CreateCategory(new Category { Name = "Location" });
            _CategoriesController.CreateCategory(new Category { Name = "Weapon" });
            _CategoriesController.CreateCategory(new Category { Name = "Suspects" });

            SetupCards(_CategoriesController.GetCategory(1), 
                new string[] { "Hall", "Lounge", "Dining Room", "Kitchen", "Ball Room", "Conservatory", "Billiard Room", "Library", "Study" });
            SetupCards(_CategoriesController.GetCategory(2),
                new string[] { "Knife", "Candlestick", "Revolver", "Rope", "Lead Pipe", "Wrench" });
            SetupCards(_CategoriesController.GetCategory(3),
                new string[] { "Col. Mustard", "Prof. Plum", "Mr. Green", "Mrs. Peacock", "Miss Scarlett", "Mrs. White" });


            foreach(Category category in _CategoriesController.GetCategory())
            {
                Console.WriteLine("Below are the cards in the {0} stack", category.Name);
                foreach (Card card in _CardController.GetCard(category))
                {
                    Console.WriteLine(card.Name);
                }
            }
            Console.ReadLine();


        }

        static void SetupCards(Category category, string[] names)
        {
            foreach(string name in names)
            {
                _CardController.CreateCard(new Card
                {
                    Name = name,
                    Category = category
                });
            }
        }
    }
}
