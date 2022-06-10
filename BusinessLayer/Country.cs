using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Country
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public string Name { get; set; }

        private Country() { }

        public Country(string name)
        {
            Name = name;
        }

    }
}
