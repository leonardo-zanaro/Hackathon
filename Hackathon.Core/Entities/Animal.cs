using Hackathon.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Animal
    {
        public string Nome { get; set; }
        public string MicroChip { get; set; }
        public string Cor { get; set; }
        public string Observacao { get; set; }
        public DateTime? Nascimento { get; set; }
        public TipoAnimais Tipo { get; set; }
        public Guid? RacaId { get; set; }
    }
}
