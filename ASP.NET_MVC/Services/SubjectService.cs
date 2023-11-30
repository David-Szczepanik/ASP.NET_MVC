using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ASP.NET_MVC.Services {
    public class SubjectService {
        public ApplicationDbContext dbContext;
        public SubjectService(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Subject>> GetAllAsync() {
            return await dbContext.Subjects.ToListAsync();
        }
        public async Task CreateStudentAsync(Subject subject) {
            await dbContext.Subjects.AddAsync(subject);
            await dbContext.SaveChangesAsync();
        }
        internal async Task <Subject> GetById(int id) {
            return await dbContext.Subjects.FirstOrDefaultAsync(st => st.Id == id);
        }

        internal async Task UpdateAsync(Subject subject) {
            dbContext.Subjects.Update(subject);
            await dbContext.SaveChangesAsync();
        }

        internal Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }
    }
}
