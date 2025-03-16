using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyEating.Models
{
    public class DishInOrder
    {
        public long DishId { get; set; }
        public virtual Dish Dish { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Count { get; set; }
    }
}
