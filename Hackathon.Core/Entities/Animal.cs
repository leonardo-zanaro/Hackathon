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
        public DateTime? Nascimento { get; set; }

        [ForeignKey("TipoAnimal")]
        public Guid TipoAnimalId { get; set; }
    }
}
