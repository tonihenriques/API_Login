using API_Treinamento_Auth.Entidades;

namespace API_Treinamento_Auth.Repository
{
    public class UserRepository
    {

        public static User Get(string username, string password)
        {
            var user = new List<User>()
            {
                new User() { id = 1, Username = "Antonio", Password = "1234", Role = "Amin" },
                new User() { id = 2, Username = "Joao", Password = "1234", Role = "customer" }

            };

            var response = user.Where(x => x.Username.ToLower() == username.ToLower()
                                && x.Password.ToLower() == password.ToLower()).FirstOrDefault();


            return response;

        }
    }
}
