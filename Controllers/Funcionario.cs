using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    public class FuncionarioController : Controller {
        public static List<Funcionario> Funcionarios(){
            return Funcionario.Funcionarios();
        }

        public static void AddFuncionario(int id, string nome, string cpf){
            new Funcionario(id, nome, cpf);
        }
    }
}