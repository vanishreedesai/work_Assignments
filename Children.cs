using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.models
{
    [Table("Children")]
    public class Children
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildrenID { get; set; }

        public string Name { get; set; }

        public string School { get; set; }

        public int Age { get; set; }

        public Parent Mom { get; set; } //FK
    }
}
