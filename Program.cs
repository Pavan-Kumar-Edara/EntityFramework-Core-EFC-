using EntityFrameworkCoreDemo.Data;
using EntityFrameworkCoreDemo.Models;

namespace EntityFrameworkCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SportsDbContext context = new SportsDbContext();

            //Cricketers cricketersDetails = new Cricketers()
            //{
            //    cricketerName="Rohit",
            //    cricketerLocation="Mumbai",
            //    role="Batting"
            //};

            //context.Add(cricketersDetails);
            //context.SaveChanges();

            //Cricketers cricketersDetailsTwo = new Cricketers()
            //{
            //    cricketerName = "Dhoni",
            //    cricketerLocation = "Chennai",
            //    role = "Batting"
            //};
            //context.Add(cricketersDetailsTwo);
            //context.SaveChanges();




            //var updateRole=context.Cricketers.Where(a=>a.role=="Batting").First();
            //if(updateRole is Cricketers)
            //{
            //    updateRole.role = "AllRounder";
            //}
            //context.SaveChanges();


            //var deleteRow=context.Cricketers.Where(a=>a.cricketerId==2).First();
            //if(deleteRow is Cricketers)
            //{
            //    context.Remove(deleteRow);
            //}
            //context.SaveChanges();

            var details = context.Cricketers.Where(a => a.cricketerId > 0).OrderBy(x => x.cricketerName);
            foreach (Cricketers detail in details)
            {
                Console.WriteLine(detail.cricketerName+" "+detail.cricketerLocation);
            }
        }
    }
}