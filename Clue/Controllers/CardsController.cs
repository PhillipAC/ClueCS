using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clue.Models;

namespace Clue.Controllers
{
    class CardsController
    {
        private GameMemory _context;

        public CardsController()
        {
            _context = new GameMemory();
        }

        public ICollection<Card> GetCard(Category category)
        {
            return _context.Cards.Where(c => c.Category == category).ToList();
        }

        public ICollection<Card> GetCard()
        {
            return _context.Cards;
        }

        public Card GetCard(int Id)
        {
            Card card = _context.Cards.First(c => c.Id == Id);
            return card;
        }

        public Card UpdateCard(int Id, Card card)
        {
            Card SaveCard = _context.Cards.First(c => c.Id == Id);
            SaveCard = card;
            return SaveCard;
        }

        public Card CreateCard(Card card)
        {

            card.Id = _context.Cards.Count() + 1;
            _context.Cards.Add(card);

            return card;
        }

        public void DeleteCard(Card card)
        {
            _context.Cards.Remove(card);
        }
    }
}
