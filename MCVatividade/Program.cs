using AtividadeMVC.Model;
using AtividadeMVC.View;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC
{
    public class Program
    {
        static void Main(string[] args)

        // ctrl+k+d para arrumar  o codigo
        {
            string opcao;
            do
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos Cadastrados");
                Console.WriteLine("3 - Atualizar produtos");
                Console.WriteLine("4 - Deletar Produtos");
                Console.WriteLine("5 - Encerrar programa");


                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {

                    case 1:
                        AddVendaView.addProduto();
                        break;

                    case 2:
                        ListaVendaView.ListarProduto();
                        break;

                    case 3:
                        AtualizarVendaView.attVenda();
                        break;

                    case 4:
                        RemoverVendaView.deletarProduto();
                        break;

                    case 5:
                        EncerrarProgramaVendaView.sair();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;

                }
                Console.WriteLine("Deseja Continuar? (S/N)");
                opcao = Console.ReadLine().ToUpper();



            }
            while (opcao == "S");

        }


    }
}
