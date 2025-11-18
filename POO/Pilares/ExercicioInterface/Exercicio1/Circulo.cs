using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Circulo : IForma
    {   
            public float Raio;

            public float PI =3.14f;

            public void caucularArea()
        {
            Console.WriteLine($"O Raio do circulo é {PI * Raio * Raio}");
        }
    }
}