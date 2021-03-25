using System;
using System.Text;

namespace FirstApp
{
    class Program
    {
       
        static (string NameUser, string LastName, int AgeUser, bool isHavePet, int CountPets, string[] NamePets, int CountColors, string[] NameColors) EnterUser()
        {
            (string NameUser, string LastName, int AgeUser, bool isHavePet, int CountPets, string[] NamePets, int CountColors, string[] NameColors) User;

            Console.WriteLine("Введите своё имя");
            User.NameUser = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите свой возраст цифрами");
                age = Console.ReadLine();

            } while (!CheckNum(age,out intage));

            User.AgeUser = intage;

            Console.WriteLine("Есть ли у вас питомцы? Да или Нет");

            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.isHavePet = true;
                string countpets;
                int intcountpets; 
                
                do
                {
                    Console.WriteLine("Введите количество ваших питомцев");
                    countpets = Console.ReadLine();

                } while (!CheckNum(countpets, out intcountpets));

                User.CountPets = intcountpets;
                User.NamePets=CreateArrayPets(User.CountPets);
            }
            else
            {
                User.isHavePet = false;
                User.CountPets = 0;
                User.NamePets = new string[0];
            }

            string countcolors;
            int intcountcolors;

            do
            {
                Console.WriteLine("Введите количество ваших любимых цветов радуги");
                countcolors = Console.ReadLine();

            } while (!CheckNum(countcolors, out intcountcolors));

            User.CountColors = intcountcolors;
            User.NameColors = CreateArrayColors(User.CountColors);

            Console.WriteLine();

            return User;
        }
        static bool CheckNum(string num, out int intnum)
        {
            if (int.TryParse(num, out int resnum))
            {
                if (resnum > 0)
                {
                    intnum = resnum;
                    return true;
                }

                if (resnum == 0)
                {
                    intnum = 0;
                    return true;
                }
            }
            
            {
                intnum = 0;
                return false;
            }
                
        }
        static string[] CreateArrayPets(int num)
        {
            var result = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Введите имя {0}-го питомца", i+1);
                result[i] = Console.ReadLine();
            }
            
            return result;
        }

        static string[] CreateArrayColors(int num)
        {
            var result = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Введите {0}-й цвет", i+1);
                result[i] = Console.ReadLine();
            }

            return result;
        }

        static void ShowUser((string NameUser, string LastName, int AgeUser, bool isHavePet, int CountPets, string[] NamePets, int CountColors, string[] NameColors) NewUser)
        {
            Console.WriteLine("Ваше имя:");
            Console.WriteLine(NewUser.NameUser);

            Console.WriteLine("Ваша фамилия:");
            Console.WriteLine(NewUser.LastName);

            Console.WriteLine("Ваш возраст:");
            Console.WriteLine(NewUser.AgeUser);

            Console.WriteLine("У вас {0} питомцев", NewUser.CountPets);

            if(NewUser.isHavePet && NewUser.CountPets > 0)
            {
                Console.WriteLine("Ваших питомцев зовут:");
                foreach (var item in NewUser.NamePets)
                {
                    Console.WriteLine(item + " ");
                }           
            }
          
            Console.WriteLine("У вас {0} любимых цветов", NewUser.CountColors);

            if(NewUser.CountColors>0)
            {
                Console.WriteLine("Ваши любимые цвета:");
                foreach (var item in NewUser.NameColors)
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
        static void Main(string[] args)
		{
            ShowUser(EnterUser());
       
        }
    }
}

