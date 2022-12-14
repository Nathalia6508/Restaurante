using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public abstract class BaseRepo<Tipo> where Tipo : class
    {
        public abstract Tipo Create(Tipo instancia);

        public abstract Tipo ReadOne(int chave);

        public abstract List<Tipo> ReadAll();

        public abstract Tipo Update(Tipo instancia);

        public abstract Tipo Delete(Tipo instancia);
    }
}
