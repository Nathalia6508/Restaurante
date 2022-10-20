using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace FakeDB
{
    public class FisicaFakeDB
    {
        private static List<Fisica> pessoasFisicas;

        public static List<Fisica> PessoasFisicas
        {
            get
            {
                if (PessoasFisicas == null)
                {
                    pessoasFisicas = new List<Fisica>();
                    Preencher();
                }
                return pessoasFisicas;
            }
        }

        public static void Preencher()
        {
            
            pessoasFisicas.AddRange(new Fisica(1975 - 03 - 15,
                                    "Maria",
                                    "maria123@gmail.com",
                                    "67998889988",
                                    "São Paulo",
                                    "123",
                                    1,
                                    "99999999999"));
            
        }
    }
}
