using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyEating.Models
{
    public class Order
    {
        public long Id { get; set; }
        public virtual User User { get; set; }
        public DateOnly Date {  get; set; }
        public TimeOnly Time { get; set; }
        public int Table {  get; set; }

        [StringLength(50)]
        public string? Comment { get; set; }
        public virtual Status Status { get; set; }

        public virtual List<DishInOrder> DishesInOrder { get; set; }
    }
}
