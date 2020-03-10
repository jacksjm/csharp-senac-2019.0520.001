using System;
using View;

namespace MvcExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClienteView.GetClientes();
            FuncionarioView.GetFuncionarios();
        }

    }
}
