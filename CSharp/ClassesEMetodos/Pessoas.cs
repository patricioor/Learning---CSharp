using System;


namespace CSharp.ClassesEMetodos {
    class Pessoas {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format("Olá, meu nome é {0}. Tenho {1} anos.",Nome,Idade);
        } 
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
