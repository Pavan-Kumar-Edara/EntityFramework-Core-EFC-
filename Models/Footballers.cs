using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class Footballers
    {
        [Key]
        public int footballerId { get; set; }

        public string footballerName { get; set; }

        public string footballerLocation { get; set; }

        public string role { get; set; }
    }
}
