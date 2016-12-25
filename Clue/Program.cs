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

            foreach(Card card in _CardController.GetCard())
            {
                Console.WriteLine("{0} is a {1} card with id {2}", card.Name, card.Category.Name, card.Id);
            }

            Console.WriteLine("Again below are all the weapons.");
            foreach (Card card in _CardController.GetCard(_CategoriesController.GetCategory(2)))
            {
                Console.WriteLine(card.Name);
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
