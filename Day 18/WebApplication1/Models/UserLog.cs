using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserLog
    {
        [Required]
        //[DataType(DataType.EmailAddress)]
        public string Email {  get; set; }

        [DataType(DataType.Password)]
        public string Password {  get; set; }
        public bool Remember {  get; set; }
    }
}
