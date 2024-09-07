using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerAPICore.Models.Unidade
{
    public class UnidadeViewModel
    {
        public int id { get; set; }

        [MaxLength(20)]
        public string descricao { get; set; }

        [Precision(18, 4)]
        public decimal multiplo { get; set; }
    }
}