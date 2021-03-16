using System;
using System.ComponentModel.DataAnnotations;

namespace Adminer.Models
{
    public class ApplicationDTO
    {
        [Key]
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
    }
}
