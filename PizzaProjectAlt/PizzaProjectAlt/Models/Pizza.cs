using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaProjectAlt.Models
{
    public class Pizza
    {
        public string doughType { get; set; }
        public string sauceType { get; set; }
        public string cheeseType { get; set; }
        public string toppingOne { get; set; }
        public string toppingTwo { get; set; }
        public string toppingThree { get; set; }
        public string toppingFour { get; set; }
        public string toppingFive { get; set; }
    }

    public class PizzaDBContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
    }
}