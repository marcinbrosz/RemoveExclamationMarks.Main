using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveExclamationMarks.Library;

namespace RemoveExclamationMarks.Main
{
    class RemoveExclamationMarksConsola
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                RemoveExclamationMarks.Library.RemoveExclamationMarks.RemoverMarks("!!aa!!!aa"));

            Console.Read();
        }
    }
}
