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

        public Country Read(int key, bool useNavigationProperties = false)
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

        public IEnumerable<Country> ReadAll(bool useNavigationProperties = false)
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

        public void Update(Country item, bool useNavigationProperties = false)
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
    }
}
