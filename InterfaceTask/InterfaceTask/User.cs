using System;
namespace InterfaceTask
{
    class User : IAccount
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }



        public string ShowInfo()
        {
            return $"istifadeci adi:{Name} \n istifadeci emaili{Email}";
        }


        public void PassWordChecker(string password)
        {
            bool check = true;
            while (check)
            {
                bool BoyukHerf = false;
                bool KicikHerf = false;
                bool Reqem = false;
                if (password.Length >= 8)
                {
                    foreach(char item in password)
                    {
                        if (char.IsDigit(item))
                        {
                            Reqem = true;
                        }
                        else if (char.IsLower(item))
                        {
                            KicikHerf = true;
                        }
                        else if (char.IsUpper(item))
                        {
                            BoyukHerf = true;
                        }
                        if(BoyukHerf && KicikHerf && Reqem)
                        {
                            check = false;
                            break;
                        }

                        
                        
                    }
                }
                if (!BoyukHerf || !KicikHerf || !Reqem)
                {
                    Console.WriteLine("Yeniden sifre daxil edin");
                    password = Console.ReadLine();
                }
            }

            
        }
    }
}
