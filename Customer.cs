﻿using System;
using ConsoleApp2.models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp2.models
{
    
        [Table("Customer")]
        public class Customer
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int ID { get; set; }


            public string Name { get; set; }
            public int Age { get; set; }



            public virtual ICollection<Order> Orders { get; set; } //navigation prop
        }


  
}
