using System.ComponentModel.DataAnnotations;

namespace _1_MvcProject_UI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz")]
        public string Name { get; set; }
    }
}
