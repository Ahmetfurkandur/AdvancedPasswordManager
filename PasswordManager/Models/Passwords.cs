using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models
{
    [Table("Passwords")]
    public class Passwords
    {
        [Key]
        public int Id { get; set; }

        public string Platform { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
