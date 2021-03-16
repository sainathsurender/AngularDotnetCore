using System;
using System.ComponentModel.DataAnnotations;

namespace Adminer.Models
{
    public class UsersDTO
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
