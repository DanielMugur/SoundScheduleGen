using Microsoft.EntityFrameworkCore;
using SoundScheduleGen.Domain.DL;

namespace SoundScheduleGen.Infrastucture.DL
{
    public class DataContext : DbContext
    {
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