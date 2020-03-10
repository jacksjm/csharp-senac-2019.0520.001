using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models {
    public class Funcionario {
        private int ID { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public Funcionario (int id, string nome, string cpf){
            ID = id;
            Nome = nome;
            Cpf = cpf;
            RepositoryFuncionario.AddFuncionario(this);
        }
        public static List<Funcionario> Funcionarios () {
            return RepositoryFuncionario.Funcionarios();
        }

        public override string ToString(){
            return $"{ID} - {Nome} - C.P.F. {Cpf}";
        }
    }
}