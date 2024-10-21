using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.DTOs.Requests
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo de Email é invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de senha é obrigatório")]
        public string Password { get; set; }
    }
}
