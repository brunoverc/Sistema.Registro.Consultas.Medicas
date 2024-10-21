using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.DTOs.Responses
{
    public class UserRegisteredResponse
    {
        public UserRegisteredResponse()
        {
            Errors = new List<string>();
        }
        public UserRegisteredResponse(bool success = true) : this()
        {
            Success = success;
        }
        public bool Success { get; private set; }
        public List<string> Errors { get; private set; }
        public void AddError(string error)
        { 
            Errors.Add(error); 
        }
        public void AddErrors(List<string> errors)
        {
            Errors.AddRange(errors);
        }
    }
}
