using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Domain.Models
{
    public class Topping
    {
        public int ToppingId { get; set; }
        public string Name { get; set; }
        public List<Pizza> pizzas { get; set; }
    }
}
