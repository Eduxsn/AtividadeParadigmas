using System;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            Cliente cliente = new Cliente();
            cliente.Nome = "Eduardo Henrique";
            cliente.Cpf = "999.999.999-99";

            //Endereco
            cliente.Rua = "Rua João Ramon";
            cliente.Numero = 97;
            cliente.Bairro = "Campo Belo";
            cliente.Cidade = "Olimpia";
            cliente.Cep = "15406-628";

            //Cidade
            cliente.CidadeNome = "Olímpia";
            cliente.EstadoNome = "São Paulo";
            cliente.EstadoUF = "SP";

            string msg = "\n Nome: " + cliente.Nome + "\n CPF: " + cliente.Cpf + "\n Rua: " + cliente.Rua + 
            "\n Número: " + cliente.Numero + "\n Bairro: " + cliente.Bairro + "\n Cidade: " + cliente.Cidade + 
            "\n CEP: " + cliente.Cep + "\n Nome do Estado: " + cliente.EstadoNome + "\n UF do Estado: " + cliente.EstadoUF;


            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}