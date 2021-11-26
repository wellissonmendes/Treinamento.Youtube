using NUnit.Framework;
using System;

namespace Treinamento
{
    public class Teste
    {
        [Test]
        public void Test1()
        {

            string nomeString = "Wellisson";
            var nomeVar = "Wellisson var";
            object nomeObj = "Wellisson obj";


            int numeroInt = 1;
            var numeroVar = 2;
            object numeroObj = 3;


            bool eHomem = true;
            var eMulher = false;
            object eObj = true;

            Console.WriteLine($"Olá! meu nome é {nomeString} e tenho {numeroVar} anos! ");
        }

    }
}
