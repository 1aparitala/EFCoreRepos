using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore
{
    [Table("Product")]
    public class Product
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        //reference naviation property
        public Category Category { get; set; }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EFCore
//{
//    class Product
//    {

//        public int ProductID { get; set; }
//        public string ProductName { get; set; }
//        public string Description { get; set; }
//        public decimal UnitPrice { get; set; }
//        public int CategoryID { get; set; }
//    }
//}
