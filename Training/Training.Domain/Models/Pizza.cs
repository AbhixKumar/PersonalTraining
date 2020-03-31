using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Domain.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public Size size { get; set; }
        public Crust crust { get; set; }
        public List<Topping> toppings { get; set; }
    }
}
