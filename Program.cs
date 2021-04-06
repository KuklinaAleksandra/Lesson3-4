using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] symds = { 
                {'O', 'X', 'O','O', 'O', 'O', 'O', 'X', 'X', 'O'},
                {'O', 'X', 'O','X', 'X', 'X', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O','O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O','O', 'X', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'O','O', 'O', 'O', 'X', 'O', 'X', 'O'},
                {'O', 'O', 'O','O', 'O', 'O', 'O', 'O', 'X', 'O'},
                {'O', 'O', 'O','O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'X', 'O', 'O','O', 'O', 'O', 'O', 'O', 'O', 'X'},
                {'X', 'O', 'O','O', 'O', 'X', 'X', 'O', 'O', 'O'},
                {'X', 'O', 'O','O', 'O', 'O', 'O', 'O', 'O', 'X'}};

            for (int i=0; i<10;i++)
            {
                for (int j=0; j<10; j++)
            

            Console.Write(symds[i,j] + "  ");
            Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
