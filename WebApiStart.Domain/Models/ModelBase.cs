using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiStart.Domain.Models
{
    public class ModelBase
    {
        public ModelBase()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Deletado { get; private set; }

        public void Deletar()
        {
            this.Deletado = true;
        }
    }
}
