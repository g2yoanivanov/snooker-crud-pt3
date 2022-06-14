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
                HashSet<Player> list = new HashSet<Player>(item.Players.Count());

                foreach (Player player in item.Players)
                {
                    Player fromDB = _context.Players.Find(player.Id);

                    if (fromDB != null)
                    {
                        list.Add(fromDB);
                    }
                    else
                    {
                        list.Add(player);
                    }
                }

                item.Players = list;

                _context.Tournaments.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tournament Read(int key)
        {
            try
            {
                IQueryable<Tournament> query = _context.Tournaments;

                query = query.Include(t => t.Players);

                Tournament fromDB = query.SingleOrDefault(t => t.Id == key);

                if (fromDB == null)
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

        public IEnumerable<Tournament> ReadAll()
        {
            try
            {
                IQueryable<Tournament> query = _context.Tournaments;

                query = query.Include(t => t.Players);

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Tournament item)
        {
            try
            {
                Tournament fromDB = Read(item.Id);

                HashSet<Player> players = new HashSet<Player>();

                foreach (Player player in item.Players)
                {
                    Player playerFromDB = _context.Players.Find(player.Id);

                    if (playerFromDB != null)
                    {
                        players.Add(playerFromDB);
                    }
                    else
                    {
                        players.Add(player);
                    }
                }

                fromDB.Players = players;

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
