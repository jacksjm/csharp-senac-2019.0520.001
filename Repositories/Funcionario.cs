using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryFuncionario {
        private static readonly List<Funcionario> funcionarios = new List<Models.Funcionario>();

        public static List<Funcionario> Funcionarios(){
            return funcionarios;
        }

        public static void AddFuncionario(Funcionario funcionario){
            funcionarios.Add(funcionario);
        }
    }
}