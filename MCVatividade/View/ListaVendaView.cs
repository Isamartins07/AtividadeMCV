using AtividadeMVC.Controller;
using AtividadeMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC.View
{
    public class ListaVendaView
    {
        public static void ListarProduto()
        {
            using (var context = new DBVENDAS())
            {
                // Exemplo de consulta simples para selecionar todos os produtos de venda
                var Vendas = context.Vendas.ToList();   //LISTAR A TABELA VENDAS

                foreach (var listavendas in Vendas)
                {
                    Console.WriteLine($"Id: {listavendas.Id}, Produto: {listavendas.Produto}," +
                     $" Descrição: {listavendas.Descricao}, Data: {listavendas.DataVenda}, Valor: {listavendas.ValorProduto}");
                }
            }
            Console.ReadKey();

        }
    }
}
