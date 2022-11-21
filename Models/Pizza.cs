using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }

        public Pizza(int id, string name, string description, string photo, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Photo = photo;
            Price = price;
        }
    }
}
