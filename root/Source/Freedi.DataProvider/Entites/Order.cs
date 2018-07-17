﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedi.DataProvider.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
        public DateTime Date { get; set; }
    }
}
