namespace proiectIP.Models
{
    class User
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User(string user, string password)
        {
            this.Username = user;
            this.Password = password;
        }
    }
}
