using System;
using Models;
using Controllers;

namespace View {
    public class FuncionarioView {
        public static void GetFuncionarios(){
            FuncionarioController.AddFuncionario(1, "Jackson", "00100200304");
            FuncionarioController.AddFuncionario(2, "João", "00200300405");
            FuncionarioController.AddFuncionario(3, "José", "00300400506");
            foreach (Funcionario cliente in FuncionarioController.Funcionarios())
            {
                Console.WriteLine(cliente);   
            }
        }
    }
}