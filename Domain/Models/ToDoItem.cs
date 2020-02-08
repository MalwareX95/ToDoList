using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Descrption { get; set; }
        public DateTime EventDay { get; set; }
    }
}
