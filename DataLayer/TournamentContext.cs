using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class TournamentContext : IDB<Tournament, int>
    {
        private SnookerCRUDDbContext _context;

        public TournamentContext(SnookerCRUDDbContext context)
        {
            _context = context;
        }

        public void Create(Tournament item)
        {
            try
            {
                _context.Tournaments.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    

        public Tournament Read(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Tournament> query = _context.Tournaments;

                if (useNavigationProperties)
                {
                    query = query.Include(t => t.Players);
                }

                Tournament fromDB = query.SingleOrDefault(t => t.Id == key);

                if(fromDB == null)
                {
                    throw new ArgumentException("The is no tournament with that ID!");
                }

                return fromDB;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Tournament> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Tournament> query = _context.Tournaments;

                if (useNavigationProperties)
                {
                    query = query.Include(t => t.Players);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Tournament item, bool useNavigationProperties = false)
        {
            try
            {
                Tournament fromDB = Read(item.Id, useNavigationProperties);

                if (useNavigationProperties)
                {
                    List<Player> players = new List<Player>();

                    foreach (Player player in item.Players)
                    {
                        Player playerFromDB = _context.Players.Find(player.Id);

                        if(playerFromDB != null)
                        {
                            players.Add(playerFromDB);
                        }
                        else
                        {
                            players.Add(player);
                        }
                    }

                    fromDB.Players = players;
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
                _context.Tournaments.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
