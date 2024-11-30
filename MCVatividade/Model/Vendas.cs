using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//model representa uma entidade = tabela,
//model reprenta todas as informações para representar as tabelas 
//informações que serão manipuladas //

namespace AtividadeMVC.Model
{
    [Table("Vendas")]
    public partial class Vendas
    {
        public int Id { get; set; } // ENVIA  E RECEBE

        [Column("Produto")]
        public string Produto { get; set; }

        [Required]
        [Column("Descricao")]
        public string Descricao { get; set; }

        [Required]
        [Column("DataVenda")]
        public DateTime DataVenda { get; set; }

        [Required]
        [Column("ValorProduto")]
        public decimal ValorProduto { get; set; }
    }
}
