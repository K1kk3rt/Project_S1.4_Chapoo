using System;
using System.Collections.Generic;
using MODEL;
using DAL;
using LOGIC;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dao = new LoginDAO();
                Console.WriteLine(dao.GetPersoonId(new Login("Des", "bier")));
            }
            catch (StackOverflowException patat)
            {
                Console.WriteLine(patat.Message);
            }
            catch (IndexOutOfRangeException dik)
            {

            }
        }
    }
}
