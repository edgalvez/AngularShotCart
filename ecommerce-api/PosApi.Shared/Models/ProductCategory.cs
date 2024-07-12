using PosApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PosApi.Data.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Boolean Inactive { get; set; } = false;
        public string? CreatedBy { get; set; } 
        public DateTime? CreatedAt { get; set; }
        public string? LastUpdateBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        [ForeignKey(nameof(CategoryId))] 
        
        public virtual ICollection<ProductSubCategory> ProducSubtCategories { get;set; }

        
    }
}
