using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_dotnet_core.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public int PlantsRequired { get; set; }
        public int NurseryId { get; set; }
        public int Total { get; set; }
        public bool Paid { get; set; }
    }
}
