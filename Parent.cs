using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp2.models
{
    [Table("Parent")]
    public class Parent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentID { get; set; }


        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public virtual ICollection<Children> Kids { get; set; } //navigation prop
    }
}
