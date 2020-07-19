using System;

namespace AuthenticationJWT.Model
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DatetimeInsert { get; set; }
        public bool IsDelected { get; set; }
    }
}
