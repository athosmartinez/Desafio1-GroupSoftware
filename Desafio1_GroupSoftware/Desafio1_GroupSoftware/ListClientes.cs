using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio1_GroupSoftware;

namespace Desafio1_GroupSoftware
{
    public static class ListClientes
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static void CriarObjClientes()
        {
            clientes.Clear();
            Cliente cliente = new Cliente();
            cliente.Nome = "Athos";
            cliente.Email = "email.teste@gmail.com";
            cliente.Endereco = "Rua São Tome, 545";
            cliente.Documento = "999,000,999-00";
            cliente.Telefone = "(99) 99999-9090";
            clientes.Add(cliente);

            cliente = new Cliente();
            cliente.Nome = "Pedro";
            cliente.Email = "teste.teste@gmail.com";
            cliente.Endereco = "Rua São Jão, 545";
            cliente.Documento = "999,000,999-00";
            cliente.Telefone = "(99) 99999-9090";
            clientes.Add(cliente);

            cliente = new Cliente();
            cliente.Nome = "João";
            cliente.Email = "teste.email@gmail.com";
            cliente.Endereco = "Rua São Pedro, 545";
            cliente.Documento = "999,000,999-00";
            cliente.Telefone = "(99) 99999-9090";
            clientes.Add(cliente);
        }


    }
}
