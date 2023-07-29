using Microsoft.EntityFrameworkCore;
using SoundScheduleGen.Domain.DL;
using SoundScheduleGen.Domain.DL.Person;

namespace SoundScheduleGen.Infrastucture.DL
{
    public class DataContext : DbContext
    {
        #region Constants and Variables

        public DbContext DbContext { get; }
        private readonly string _connectionString;

        #endregion

        #region DbConfig

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_connectionString);
        }

        #endregion


        #region Constructors
        public DataContext()
        {
            
        }

        #endregion

        #region DbSetMembers

        public DbSet<PersonHermano> PersonHermano { get; set; }


        #endregion
    }
}