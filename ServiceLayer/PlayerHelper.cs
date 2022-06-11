using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PlayerHelper
    {
        public static int FindByName(string firstName, string lastName)
        {
            return DbContextManager.GetPlayerContext().FindByName(firstName, lastName);
        }
    }
}
