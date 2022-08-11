using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InecVotersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] voterNames = { "Daniel", "Jude", "Sandra", "Tosin", "Jude", "Michael", "Jude", "Tosin" };
            var dict = new Dictionary<string, int>();
            try// Prevent system crash with exception message
            {

            }
            catch (Exception maco)
            {

                Console.WriteLine("Something's wrong here.");
            }
            foreach (var name in voterNames)
            {
                if (dict.ContainsKey(name))
                    dict[name]++;
                else
                    dict[name] = 1;
            }
            foreach (var name in dict)
            {
                if (name.Value > 1)
                {
                   Console.WriteLine(name.Key + " "+ "voted" + " "+ name.Value + " " + "times");
                }
            }
           

        }/// <summary>
        /// This method prevents duplicate entry of voters
        /// </summary>
        public void PreventDuplicate()
        {
            Console.Write("Welcome to the registration page. Please enter your name: ");
            string name = Console.ReadLine();
            HashSet<string> voters = new HashSet<string>()
            { "Daniel", "Sandra", "Jude", "Michael", "Tosin" };
            
            if (voters.Contains(name))
            {
                Console.WriteLine($"{name} already exists");
            }
            else
            {
                voters.Add(name);
                Console.WriteLine($"{name} added successfully");
                Console.ReadLine();
            }
        }
    }

}