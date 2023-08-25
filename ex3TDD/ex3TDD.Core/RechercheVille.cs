using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3TDD.Core
{
    public class RechercheVille
    {
        private List<String>? _villes;

        public List<String>? Villes
        {
            get { return _villes; }
            set { _villes = value; }
        }

        public List<String> Rechercher(String mot)
        {
            throw new NotImplementedException();
        }
    }
}
