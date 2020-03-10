using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models {
    public class Cliente {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Cliente (int id, string nome){
            ID = id;
            Nome = nome;
            RepositoryCliente.AddCliente(this);
        }
        public static List<Cliente> Clientes () {
            return RepositoryCliente.Clientes();
        }

        public override string ToString(){
            return $"{ID} - {Nome}";
        }
    }
}