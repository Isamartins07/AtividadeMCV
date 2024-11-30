using AtividadeMVC.Controller;
using AtividadeMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC.View
{
    public class AddVendaView
    {
        //metodos -- CRUD
        public static void addProduto()
        {
            //instanciando model venda
            string vProduto, vDescricao;
            DateTime vDate;
            decimal vValor;


            Console.WriteLine("Digite seu produto: ");
            vProduto = Console.ReadLine();

            Console.WriteLine("Digite a descrição do produto: ");
            vDescricao = Console.ReadLine();

            Console.WriteLine("Data de hoje : ");
            vDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto: ");
            vValor = Decimal.Parse(Console.ReadLine());

            using (var add = new DBVENDAS())
            {
                add.Vendas.Add(new Vendas()

                {
                    Produto = vProduto,
                    Descricao = vDescricao,
                    DataVenda = vDate,
                    ValorProduto = vValor
                });

                add.SaveChanges();
                Console.WriteLine("Produto Adicionado");
            }

            Console.ReadKey();
        }


    }

}
