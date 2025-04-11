using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_BarberShop_Code.Models.DTOs
{
    public class BarbeiroDto : ClienteDto
    {
        public string NomeBarbearia { get; set; } = string.Empty;
    }
}