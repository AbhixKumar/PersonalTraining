using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Domain.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public Sizes size { get; set; }
        public Crust crust { get; set; }
        public List<Topping> toppings { get; set; }

        public Pizza()
        {

        }
        public Pizza(Sizes _size, Crust _crust)
        {          
            size = _size;
            crust = _crust;
        }
    }
}
