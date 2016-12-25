using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue.Models
{
    class GameMemory
    {
        public ICollection<Card> Cards { get; set; }
        public ICollection<Category> Categories { get; set; }

        public GameMemory()
        {
            Cards = new List<Card>();
            Categories = new List<Category>();
        }
    }
}
