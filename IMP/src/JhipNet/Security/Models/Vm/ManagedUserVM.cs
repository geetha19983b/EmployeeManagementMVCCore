using System.ComponentModel.DataAnnotations;
using com.imp.net.Service.Dto;

namespace com.imp.net.Models.Vm {
    public class ManagedUserVM : UserDto {
        public const int PasswordMinLength = 4;

        public const int PasswordMaxLength = 100;

        [Required]
        [MinLength(PasswordMinLength)]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; }

        public override string ToString()
        {
            return "ManagedUserVM{} " + base.ToString();
        }
    }
}
