using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DoJob();
        }

        static void DoJob()
        {
            var empleado = new Employee();
            empleado.startWindow();
        }
    }
}
