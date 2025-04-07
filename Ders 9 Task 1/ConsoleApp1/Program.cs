using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("Efsun Yusubzade", "efsuny@mail.ru", "EFsun12345");
                user1.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xəta: {ex.Message}");
            }
        }

        abstract class Account
        {
            public abstract bool PasswordChecker(string password);

            public virtual void ShowInfo()
            {
                Console.WriteLine("Account info");
            }
        }

        class User : Account
        {
            private static int Count = 0;

            public int Id { get; }
            public string Fullname { get; set; }
            public string Email { get; set; }
            private string _password;

            public string Password
            {
                get => _password;
                set
                {
                    if (PasswordChecker(value))
                        _password = value;
                    else
                        throw new Exception("Şifrə tələblərə cavab vermir.");
                }
            }

            public User(string fullname, string email, string password)
            {
                Id = Count++;
                Fullname = fullname;
                Email = email;
                Password = password; 
            }

            public override bool PasswordChecker(string password)
            {
                if (password.Length < 8)
                    return false;

                bool hasUpper = false;
                bool hasLower = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        hasUpper = true;
                    else if (char.IsLower(c))
                        hasLower = true;

                    if (hasUpper && hasLower)
                        break;
                }

                return hasUpper && hasLower;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Fullname: {Fullname}");
                Console.WriteLine($"Email: {Email}");
            }
        }
    }
}
