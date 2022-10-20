using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB
{
    internal class JuridicaFakeDB
    {
        private static List<Juridica> pessoasJuridicas;

        public static List<Juridica> PessoasJuridicas
        {
            get
            {
                if (PessoasJuridicas == null)
                {
                    pessoasJuridicas = new List<Juridica>();
                }
                return pessoasJuridicas;
            }
        }

       
    }
}
