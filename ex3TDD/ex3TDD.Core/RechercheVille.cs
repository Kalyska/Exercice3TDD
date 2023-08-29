using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3TDD.Core
{
    public class RechercheVille
    {
        private List<String> _villes = new List<string>();

        public List<String> Villes
        {
            get { return _villes; }
            set { _villes = value; }
        }

        public List<String> Rechercher(String mot)
        {
            if (mot == "*")
                return Villes;
            else if (mot.Length < 2)
                throw new NotFoundException();
            else
                return Villes.Where(v => v.ToLower().Contains(mot.ToLower())).ToList();
        }
    }
}
