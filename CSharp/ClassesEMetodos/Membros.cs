using System;

namespace CSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoas sicrano = new Pessoas();

            sicrano.Nome = "Patrício";
            sicrano.Idade = 20;

            sicrano.ApresentarNoConsole();
        }
    }
}
