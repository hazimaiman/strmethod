using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Hazim Aiman";
            String phoneNumber = "123-4560-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); 

            String firstName = fullName.Substring(0,5);
            String lastName = fullName.Substring(6,5);
            
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);



            

            Console.ReadKey();

        }

    }

}
