namespace API_Treinamento_Auth.Entidades
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
    }
}
