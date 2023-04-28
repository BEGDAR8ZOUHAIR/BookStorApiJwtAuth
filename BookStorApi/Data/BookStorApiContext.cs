using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStorApi.Models;
using ServiceStack.Text;
using Microsoft.AspNetCore.Cors;



namespace BookStorApi.Data
{
    public class BookStorApiContext : DbContext
    {
   
        public BookStorApiContext (DbContextOptions<BookStorApiContext> options)
            : base(options)
        {
          
        }
     

        public DbSet<BookStorApi.Models.BookModel> BookModel { get; set; } = default!;
    }
}
