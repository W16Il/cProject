using System;
using System.Security;

namespace cProject
{
    public class Employee
    {
        public void startWindow()
        {
            var opt = " ";
            while (opt != "X")
            {
                getMenu();
                opt = getOpt();
            }
        }

        private string getOpt()
        {
            var opt = Console.ReadLine();
            return opt;
        }

        private void getMenu()
        {
            Console.WriteLine("1. Listar Empleados");
            Console.WriteLine("X. Salir");

        }
    }
}