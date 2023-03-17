using System;
using System.Collections.Generic;

using CSharp.Fundamentos;

namespace CSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}