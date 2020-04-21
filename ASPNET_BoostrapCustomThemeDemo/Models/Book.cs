using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPNET_BoostrapCustomThemeDemo.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "8/16/2017")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is Required!")]
        [Range(1, 200, ErrorMessage = "Price must be between $1 and $200")]
        public decimal Price { get; set; }
    }

    public class BookDbContext:DbContext
        {
            public DbSet<Book> BooksDb { get; set; }
        }
        
    }
