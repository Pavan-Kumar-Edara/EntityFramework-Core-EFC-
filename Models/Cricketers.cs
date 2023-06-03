using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class Cricketers
    {
        [Key]
        public int cricketerId { get; set; }

        public string cricketerName { get; set; }

        public string cricketerLocation { get; set; }

        public string role { get; set; }
    }
}