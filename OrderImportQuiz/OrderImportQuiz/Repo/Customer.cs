using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderImport.Repo
{
    class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal CreditLimt { get; set; }
    }
}
