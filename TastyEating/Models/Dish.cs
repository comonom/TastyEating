using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TastyEating.Models
{
    public class Dish
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Precision(10,2)]
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }

        [StringLength(100)]
        public string Structure { get; set; }
        public byte[] Photo { get; set; }

        public virtual List<DishInOrder> DishInOrders { get; set; }


    }
}
