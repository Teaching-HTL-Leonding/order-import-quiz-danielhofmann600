using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OrderImport.Repo
{
    class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [NotNull]
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal OrderValue { get; set; }
    }
}
