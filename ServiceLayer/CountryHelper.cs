using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public static class CountryHelper
    {
        public static int FindByName(string name)
        {
            return DbContextManager.GetCountryContext().FindByName(name);
        }
    }
}
