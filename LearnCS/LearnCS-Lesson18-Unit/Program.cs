/*
 * Testea tu Código
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    public static class ExtensionMethods
    {

        public static int PlusFive(this int input)
        {
            return input + 5;
        }

        static void Main(string[] args)
        {
        }
    }
}
