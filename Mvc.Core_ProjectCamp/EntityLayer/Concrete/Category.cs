using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        // Property => Erişim belirleyici - veri tipi - isim { get; set; }
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakmayın.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakmayın.")]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
