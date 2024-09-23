using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerAPICore.Models.PedidoCompra
{
    public class ProdutoCompraViewModel
    {
        public int id { get; set; }

        public int idpedido { get; set; }
        public string idconta { get; set; }
        public int idproduto { get; set; }

        public decimal qtdcompra { get; set; }

        public decimal preco { get; set; }

        public decimal total { get; set; }

        public decimal recebido { get; set; }

        public string? descproduto { get; set; }
    }
}