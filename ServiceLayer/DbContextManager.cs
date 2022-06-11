using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public class DbContextManager
    {
        private static SnookerCRUDDbContext _context;
        private static CountryContext _countryContext;
        private static PlayerContext _playerContext;
        private static TournamentContext _tournamentContext;

        public static SnookerCRUDDbContext CreateContext()
        {
            _context = new SnookerCRUDDbContext();
            return _context;
        }

        public static SnookerCRUDDbContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        public static CountryContext CreateCountryContext(SnookerCRUDDbContext context)
        {
            _countryContext = new CountryContext(context);
            return _countryContext;
        }

        public static CountryContext GetCountryContext()
        {
            return _countryContext;
        }

        public static PlayerContext CreatePlayerContext(SnookerCRUDDbContext context)
        {
            _playerContext = new PlayerContext(context);
            return _playerContext;
        }

        public static PlayerContext GetPlayerContext()
        {
            return _playerContext;
        }

        public static TournamentContext CreateTournamentContext(SnookerCRUDDbContext context)
        {
            _tournamentContext = new TournamentContext(context);
            return _tournamentContext;
        }

        public static TournamentContext GetTournamentContext()
        {
            return _tournamentContext;
        }
    }
}
