using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_MVC.Services {
    public class SubjectService {
        public ApplicationDbContext dbContext;
        public SubjectService(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Subject>> GetAllAsync() {
            return await dbContext.Subjects.ToListAsync();
        }
        public async Task CreateSubjectAsync(Subject subject) {
            await dbContext.Subjects.AddAsync(subject);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Subject> GetById(int id) {
            return await dbContext.Subjects.FirstOrDefaultAsync(sub => sub.Id == id);
        }

        public async Task UpdateAsync(Subject subject) {
            dbContext.Subjects.Update(subject);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Subject subjectToDelete) {
            dbContext.Subjects.Remove(subjectToDelete);
            await dbContext.SaveChangesAsync();
        }
    }
}