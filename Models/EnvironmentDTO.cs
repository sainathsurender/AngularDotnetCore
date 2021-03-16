using System;
using System.ComponentModel.DataAnnotations;

namespace Adminer.Models
{
    public class EnvironmentDTO
    {
        [Key]
        public Guid EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
    }
}
