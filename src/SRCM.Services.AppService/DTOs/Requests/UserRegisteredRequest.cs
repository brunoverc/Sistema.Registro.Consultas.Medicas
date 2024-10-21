using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.DTOs.Requests
{
    public class UserRegisteredRequest
    {
        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo de Email é invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de senha é obrigatório")]
        [StringLength(50, ErrorMessage = "A senha deve ter entre 8 e 50 caracteres", MinimumLength = 8)]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "As senha não são iguais")]
        public string PasswordConfirm { get; set; }
    }
}
