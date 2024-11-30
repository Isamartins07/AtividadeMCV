using AtividadeMVC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC.View
{
    public class RemoverVendaView
    {
        internal static void deletarProduto()
        {
            using (var contexto = new DBVENDAS())
            {
                Console.WriteLine("Digite o ID  que deseja apagar: ");
                var busca = contexto.Vendas.Find(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Você está prestes a apagar o cadastro do Produto {busca.Produto}");
                Console.WriteLine("Tem certeza que deseja apagar, digite S para confirmar ou qualquer tecla para anular");
                var apaga = Console.ReadLine().ToUpper();
                if (apaga == "S")
                {
                    contexto.Vendas.Remove(busca);
                    contexto.SaveChanges();
                    Console.WriteLine("Cadastro do produto apagado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação anulada");

                }

            }
        }
    }
}
