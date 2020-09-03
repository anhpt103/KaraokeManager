namespace KaraokeManage.Models
{
    public class RegisterModel
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public bool Sex { get; set; }

        public RegisterModel(string fullName, string userName, string password, string rePassword, bool sex)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            RePassword = rePassword;
            Sex = sex;
        }
    }
}
