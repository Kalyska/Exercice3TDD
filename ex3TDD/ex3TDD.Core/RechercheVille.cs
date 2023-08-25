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
            if (mot.Length < 2)
                throw new NotFoundException();
            else
            {
                string motModif = mot.Substring(0, 1).ToUpper() + mot.Substring(1);
                List<String> villesTrouvees = new List<String>();
                foreach (String ville in Villes)
                {
                    if (ville.StartsWith(motModif) || ville.Contains(mot))
                    {
                        villesTrouvees.Add(ville);
                    }
                }
                return villesTrouvees;
            }
        }
    }
}
