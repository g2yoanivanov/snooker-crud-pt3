using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Tournament
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        [Required, MaxLength(64)]
        public string Location { get; set; }

        [Required, Range(100, 1000000000, ErrorMessage = "The prize pool must be between 100 and 10M!")]
        public decimal PrizePool { get; set; }

        [ForeignKey("Winner")]
        public int WinnerId { get; set; }
        [NotMapped]
        public Player Winner { get; set; }

        public IEnumerable<Player> Players { get; set; }

        private Tournament() { }

        public Tournament(string name, string location, decimal prizePool)
        {
            Name = name;
            Location = location;
            PrizePool = prizePool;
        }
    }
}
