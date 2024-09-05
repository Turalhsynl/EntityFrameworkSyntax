using ConsoleApp4.Context;
using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;

class program
{
    static async Task Main(string[] args)
    {
        DBContext dbcontext = new DBContext();
        //Category category = new Category();
        //category = new Category()
        //{
        //    Name = "Ickiler"
        //};
        //await dbcontext.Category.AddAsync(category);
        //await dbcontext.SaveChangesAsync();

        //Product product = new Product();
        //product = new Product()
        //{
        //    Name = "Sprite",
        //    Price = 2f,
        //    CategoryId = 1,
        //    InsertionDate = DateTime.Now
        //};
        //await dbcontext.Product.AddAsync(product);
        //await dbcontext.SaveChangesAsync();

        var product = await dbcontext.Product.OrderBy(p => p.Price).FirstOrDefaultAsync();
        Console.WriteLine(product.Id + ") " + product.Name + " --- " + product.Price + " - " + product.CategoryId);
    }
}