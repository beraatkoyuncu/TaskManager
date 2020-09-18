using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Data;

namespace TaskManager.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new TaskManagerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TaskManagerContext>>()))
            {

                if (context.Manager.Any())
                {
                    return;   
                }


                context.Manager.AddRange(
                    new Manager
                    {
                        ActivityName = "Toplantı",
                        ActivityDate="20.02.2021",
                        ActivityHour="09:00",
                        ActivityDesctription="Bilinmiyor.",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre ="İş",
                        Price = 7.99M


                    }

                    );

                context.SaveChanges();
            }

        }


    }
}
