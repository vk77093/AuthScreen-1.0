using AuthScreen.Models.MultipleForm;
using AuthScreen1.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthScreen1.Repo
{
    public class MultiTest : IMultiTest
    {
        private readonly ApplicationDbContext dbContext;

        public MultiTest(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<NameTable>> GetAll()
        {
            try
            {
                var AllList = await dbContext?.NameTables?.ToListAsync();
                return AllList;
            }
            catch
            {
                throw;
            }
        }
        public void AddAllTableValue(List<NameTable> nameTables)
        {
            try
            {
                dbContext?.NameTables?.AddRange(nameTables);
                dbContext?.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
