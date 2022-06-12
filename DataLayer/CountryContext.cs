using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CountryContext : IDB<Country, int>
    {
        private SnookerCRUDDbContext _context;

        public CountryContext(SnookerCRUDDbContext context)
        {
            _context = context;
        }

        public void Create(Country item)
        {
            try
            {
                _context.Countries.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Country Read(int key)
        {
            try
            {
                return _context.Countries.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Country> ReadAll()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Country item)
        {
            try
            {
                Country entry = Read(item.Id);
                _context.Entry(entry).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                _context.Countries.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int FindByName(string name)
        {
            try
            {
                List<Country> list = _context.Countries.ToList();

                foreach (Country country in list)
                {
                    if(country.Name == name)
                    {
                        return country.Id;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
