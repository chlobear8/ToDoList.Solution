// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.DependencyInjection;
// using System.Collections.Generic;
// using System;
// using ToDoList.Models;

// namespace ToDoList; //using statement because it only has one class

//   class Program
//   {
//     static void Main(string[] args)
//     {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<ToDoListContext>(dbContextOptions => dbContextOptions.UseMySql(builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
          )
        )
      );

      WebApplication app = builder.Build();

      //app.UseDeveloperExceptionPage();

      app.UseHttpsRedirection();

      app.UseStaticFiles();

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();

    //   Console.WriteLine("Welcome to the To Do List");
    //   Console.WriteLine("Would you like to add an item to your list or view your list? ['Add' or 'View']");
    //   string answer = Console.ReadLine();
    //   if (answer == "Add" || answer == "add" || answer == "ADD")
    //   {
    //     Console.WriteLine("What task would you like to add?");
    //     string task = Console.ReadLine();
    //     bool e = List<Item>.Contains(task.Item);
    //     {
    //       if (e == true)
    //       {
    //         Console.WriteLine("Task already exists");
    //       }
    //     else 
    //     {
    //     Item newItem = new Item(task);
    //     }
    //       {
    //       Main();
    //       }
    //     }
    //   }
    //   else if (answer == "View" || answer == "view" || answer == "VIEW")
    //   {
    //     List<Item> result = Item.GetAll();
    //     result.ForEach(item => Console.WriteLine("Here's your to do list: " + item.Description + ","));
      
    //   }
    //   else
    //   {
    //     Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
    //     string finishedAnswer = Console.ReadLine();
    //     if (finishedAnswer == "Y" || finishedAnswer == "y")
    //     {
    //       Console.WriteLine("Goodbye.");
    //     }
    //     else
    //     {
    //       Main();
    //     }
    //   }
//   }
// }
    