using System;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationJWT.Data
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DatetimeInsert { get; set; }
        public bool IsDelected { get; set; }
    }
}
