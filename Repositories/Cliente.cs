using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryCliente {
        private static readonly List<Models.Cliente> clientes = new List<Models.Cliente>();

        public static List<Cliente> Clientes(){
            return clientes;
        }

        public static void AddCliente(Cliente cliente){
            clientes.Add(cliente);
        }
    }
}