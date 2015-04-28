using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PizzaProjectAlt.Models
{
    public class Pizza
    {
        public int pizzaID { get; set; }
        [Display(Name = "Creator")]
        public string userID { get; set; }
        [Display(Name = "Pizza Title")]
        public string pizzaName { get; set; }
        public bool bacon { get; set; }
        public bool bpeppers { get; set; }
        public bool blackOlives { get; set; }
        public bool cheese { get; set; }
        public bool chicken { get; set; }
        public bool dough { get; set; }
        public bool gpeppers { get; set; }
        public bool ham { get; set; }
        public bool pepperoni { get; set; }
        public bool pineapple { get; set; }
        public bool sauce { get; set; }
        public bool sausage { get; set; }
        public bool spinnach { get; set; }

    }

    public class DefaultConnection : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
    }
}