namespace KaraokeManage.Models
{
    public class RegisterModel
    {
        public RegisterModel()
        {

        }

        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int Sex { get; set; }

        public RegisterModel(string fullName, string userName, string password, int sex)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            Sex = sex;
        }
    }
}
