using System;

namespace LEARNINGCSHARP_4
{
    class Program
    {
        static void Main()
        {

          Console.Write("Enter role (Admin, user): "); // Запрашивает у пользователя роль.
          string role = Console.ReadLine();  

          if(role == "Admin") //
            {
                Console.Write("Enter user name: "); //
                string user_name = Console.ReadLine(); //  Если роль хранит значение "Admin", то нас просят ввести имя пользователя, а далее возраст.
                Console.Write("Enter {0} age: ", user_name); //
                short age = Convert.ToInt16(Console.ReadLine()); //

                if(age <= 0 || age > 99) // Если возраст пользователя меньше или равно 0, а также возраст больше 99, нас просят снова ввести возраст.
                {
                Console.Write("Enter {0} age: ", user_name);
                age = Convert.ToInt16(Console.ReadLine()); 
                }

                if(age <= 0 || age > 99) // Если пользователь снова вводит этот же возраст, срабатывает ошибка.
                Console.WriteLine("Error of age.");
                
                else
                Console.WriteLine("User's age is " + age); //  Если же всё верно, выводится возраст пользователя.

            } else
                Console.WriteLine("You are not a admin!"); // Если мы ввели не "Admin", нам выводится вы не админ.
            
        }
    }
}