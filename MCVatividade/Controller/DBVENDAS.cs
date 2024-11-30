using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMVC.Controller
{
    public class DBVENDAS : DbContext // sempre por context!

    {
        public DBVENDAS() : base(@"Server=JUN0675619W10-1\BDSENAC; Database=DBVENDAS; user id=senaclivre; password = senaclivre")
        {
            // Desabilita a criação automática de tabelas
            Database.SetInitializer<DBVENDAS>(null);


        }
        public DbSet<AtividadeMVC.Model.Vendas> Vendas { get; set; }


    }
}
