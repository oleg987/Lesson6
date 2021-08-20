using System;

namespace UserData
{
    public enum Genders
    {
        Male,
        Female,
        Undefined
    }

    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Genders Gender { get; set; }

        public void WhoIs()
        {
            Console.WriteLine("User Account");
        }
    }
}
