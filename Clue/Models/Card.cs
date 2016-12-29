using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue.Models
{
    class Card
    {
        public int Id { get; set; } //Id of the card
        public Category Category { get; set; } //Category of the card
        public Player Player { get; set; } //The player who has the card
        public byte Value { get; set; } //Value of the card
        public string Name { get; set; } //Name of the card
        public bool IsUsed { get; set; } //True if used
    }
}
