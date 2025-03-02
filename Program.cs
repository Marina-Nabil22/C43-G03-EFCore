using EF_Assignment.Data;

namespace EF_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations 
            using ItiDbContext DbContext = new ItiDbContext();

            #region Insert


            //Instructor instructor = new Instructor()
            //{

            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Salary = 8000,
            //    Bouns = 500,
            //    HourRate = 200,

            //};
            //Console.WriteLine(DbContext.Entry(instructor).State);
            //DbContext.Add(instructor);
            //Console.WriteLine(DbContext.Entry(instructor).State);
            //DbContext.SaveChanges();

            var department = new Department { Name = "Computer Science", HiringDate = DateTime.Now };
            //DbContext.Departments.Add(department);
            //DbContext.SaveChanges(); 
            #endregion

            #region Select
            var Instr = (from I in DbContext.Instructors
                         where I.Id == 1
                         select I
                        ).FirstOrDefault();
            Console.WriteLine($"{Instr.Id}::{Instr.Name}::{Instr.Salary}");

            #endregion

            #region Update
            //Console.WriteLine(DbContext.Entry(Instr).State);

            //Instr.Name = "Marina";
            //DbContext.SaveChanges();
            //Console.WriteLine(DbContext.Entry(Instr).State);
            //Console.WriteLine($"{Instr.Id}::{Instr.Name}::{Instr.Salary}");

            #endregion

            #region Delete
            //Console.WriteLine(DbContext.Entry(Instr).State);
            //DbContext.Remove(Instr);    
            //DbContext.SaveChanges();
            //Console.WriteLine(DbContext.Entry(Instr).State);


            #endregion
            #endregion
        }
    }
}