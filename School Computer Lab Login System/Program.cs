using System;

namespace SchoolComputerLabLoginSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] studentIDs = { 201, 202, 203, 204 };
            int[] computerNumbers = { 1, 2, 3, 4 };
            int[] loginPasswords = { 111, 222, 333, 444 };
            int[] timeAllowed = { 60, 90, 45, 120 };

            bool idFound = false;
            bool passwordCorrect = false;
            int studentIndex = -1;

            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int authID))
            {
                Console.WriteLine("Inavalid, please try again");
                return;
            }

            Console.Write("Enter Password ID: ");
            if(!int.TryParse(Console.ReadLine(), out int authPassword))
            {
                Console.WriteLine("Invalid password, please try again");
                return;
            }


            for (int i = 0; i < studentIDs.Length; i++)
            {
            if (studentIDs[i] == authID) { 
                idFound = true;
                if (loginPasswords[i] == authPassword)
                {
                    Console.WriteLine("Login successful!");
                    Console.WriteLine($"Computer assigned: {computerNumbers[i]}");
                    Console.WriteLine($"Time allowed: {timeAllowed[i]}");
                    passwordCorrect = true;
                    break;
                }
                else
                {
                    break;
                }

               }
            }

            if (!idFound)
            {
                Console.WriteLine($"\"{authID}\" is not found on system, please try again");
            }

            else if (!passwordCorrect)
            {
                Console.WriteLine("Invalid password, please try again");
            }


        }
    }
}