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
    public class Player
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(32)]
        public string FirstName { get; set; }

        [Required, MaxLength(32)]
        public string LastName { get; set; }

        [Required, Range(5, 99, ErrorMessage = "The age must be between 5 and 99!")]
        public int Age { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        [Required]
        public Country Country { get; set; }

        [DefaultValue(0)]
        public int MatchesPlayed { get; set; }

        [DefaultValue(0)]
        public int TournamentsWon { get; set; }

        public IEnumerable<Tournament> Tournaments { get; set; }

        private Player() { }

        public Player(string firstName, string lastName, int age, Country country, int matchesPlayed, int tournamentsWon)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Country = country;
            MatchesPlayed = matchesPlayed;
            TournamentsWon = tournamentsWon;
        }
    }
}
