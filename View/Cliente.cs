using System;
using Models;
using Controllers;

namespace View {
    public class ClienteView {
        public static void GetClientes(){
            ClienteController.AddCliente(1, "Jackson");
            ClienteController.AddCliente(2, "João");
            ClienteController.AddCliente(1, "José");
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);   
            }
        }
    }
}