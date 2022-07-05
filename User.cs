namespace WebApplication3
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public byte[] Passwordhash { get; set; } = null;
        public byte[] PasswordSalt { get; set; } 
    
    }
}
