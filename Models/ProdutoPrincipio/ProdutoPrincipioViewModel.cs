using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerAPICore.Models.ProdutoPrincipio
{
    public class ProdutoPrincipioViewModel
    {
        public string idconta { get; set; }
        public int idproduto { get; set; }
        public int idprincipio { get; set; }

        public decimal quantidade { get; set; }
        public string? descprincipio { get; set; }

        public string? descproduto { get; set; }
        public string uid { get; set; }
    }
}