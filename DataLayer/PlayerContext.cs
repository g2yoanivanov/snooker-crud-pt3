using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class PlayerContext : IDB<Player, int>
    {
        private SnookerCRUDDbContext _context;

        public PlayerContext(SnookerCRUDDbContext context)
        {
            _context = context;
        }

        public void Create(Player item)
        {
            try
            {
                Country fromDB = _context.Countries.Find(item.CountryId);

                if(fromDB != null)
                {
                    item.Country = fromDB;
                }

                _context.Players.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Player Read(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Player> query = _context.Players;

                if(useNavigationProperties)
                {
                    query = query.Include(p => p.Country).Include(p => p.Tournaments);
                }

                return query.SingleOrDefault(p => p.Id == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Player> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Player> query = _context.Players;

                if (useNavigationProperties)
                {
                    query = query.Include(p => p.Country).Include(p => p.Tournaments);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Player item, bool useNavigationProperties = false)
        {
            try
            {
                Player fromDB = Read(item.Id, useNavigationProperties);

                if(useNavigationProperties)
                {
                    fromDB.Country = item.Country;

                    List<Tournament> tournaments = new List<Tournament>();

                    foreach (Tournament tournament in item.Tournaments)
                    {
                        Tournament tournamentFromDB = _context.Tournaments.Find(tournament.Id);

                        if(tournamentFromDB != null)
                        {
                            tournaments.Add(tournamentFromDB);
                        }
                        else
                        {
                            tournaments.Add(tournament);
                        }
                    }

                    fromDB.Tournaments = tournaments;
                }

                _context.Entry(fromDB).CurrentValues.SetValues(item);
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
                _context.Players.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int FindByName(string firtsName, string lastName)
        {
            try
            {
                List<Player> list = _context.Players.ToList();

                foreach(Player player in list)
                {
                    if(player.FirstName == firtsName && player.LastName == lastName)
                    {
                        return player.Id;
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
