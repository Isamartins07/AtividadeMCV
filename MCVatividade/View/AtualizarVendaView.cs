using AtividadeMVC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC.View
{
    public class AtualizarVendaView
    {
        public static void attVenda()
        {
            using (var atualizar = new DBVENDAS())
            {
                Console.WriteLine("Digite o ID Cliente que deseja alterar: ");
                var busca = atualizar.Vendas.Find(int.Parse(Console.ReadLine()));
                Console.WriteLine(busca.Produto);
                Console.WriteLine(busca.Descricao);
                Console.WriteLine(busca.DataVenda);
                Console.WriteLine(busca.ValorProduto);

                Console.WriteLine("Entre com a correção do Produto: ");
                busca.Produto = Console.ReadLine();

                Console.WriteLine("Entre com a correção da Descrição: ");
                busca.Descricao = Console.ReadLine();

                Console.WriteLine("Entre com a correção da Data: ");
                busca.DataVenda = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Entre com a correção do Valor: ");
                busca.ValorProduto = Decimal.Parse(Console.ReadLine());

                atualizar.SaveChanges();
                Console.WriteLine("Cadastro do produto alterado com sucesso! ");
            }

        }
    }
}
