using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MinLength(3, ErrorMessage = "حداقل طول، 2 کاراکتر می باشد.")]
        [MaxLength(100, ErrorMessage = "حداکثر طول، 100 کاراکتر می باشد.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است.")]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
