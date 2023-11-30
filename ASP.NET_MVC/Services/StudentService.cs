using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ASP.NET_MVC.Services {
    public class StudentService {
        public ApplicationDbContext dbContext;
        public StudentService(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Student>> GetAllAsync() {
            return await dbContext.Students.ToListAsync();
        }
        public async Task CreateStudentAsync(Student student) {
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
        }
        internal async Task <Student> GetById(int id) {
            return await dbContext.Students.FirstOrDefaultAsync(st => st.Id == id);
        }

        internal async Task UpdateAsync(Student student) {
            dbContext.Students.Update(student);
            await dbContext.SaveChangesAsync();
        }

        internal async Task DeleteAsync(Student studentToDelete) {
            dbContext.Students.Remove(new Student { Id = id });    
            await dbContext.SaveChangesAsync();

        }

    }
}
