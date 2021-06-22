using System.ComponentModel.DataAnnotations;

namespace ASP_Test_3.Entity
{
    public class User
    {
        private string login;
        private string password;
        private string name;
        private int age;

        public User(string login, string password, string name, int age)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.age = age;
        }
        
        [Required]
        [StringLength(20)]
        public string Login => login;

        [Required]
        [StringLength(100)]
        public string Password => password;

        [Required]
        [StringLength(100)]
        public string Name => name;

        [Required]
        [Range(18, 100)]
        public int Age => age;
    }
}
