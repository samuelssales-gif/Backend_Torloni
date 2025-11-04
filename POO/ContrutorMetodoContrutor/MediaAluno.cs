using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContrutorMetodoContrutor
{
    public class MediaAluno
    {
        public string Nome;

        public double N1, N2, N3;

        public MediaAluno(double param1, double param2, double Param3)
        {
            N1 = param1;
            N1 = param2;
            N3 = Param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0;
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            Console.WriteLine($"A media do {Nome} foi {Media}");
        }
    }

}