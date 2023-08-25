using ex3TDD.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3TDD.MsTest
{
    [TestClass]
    public class RechercheVilleTest
    {
        private RechercheVille _rechercheVille = new RechercheVille()
        {
            Villes = new List<String>()
            {
                "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
            }
        };

        // Si le texte de la recherche contient moins de 2 caractères, Une exception est levée de type NotFoundException
        [TestMethod]
        public void WhenRecherche_LessThan2_ThrowNotFoundException()
        {
            _rechercheVille.Rechercher("a");
            // si le texte de la recherche contient moins de 2 caractères, une exception est levée de type NotFoundException
            Assert.ThrowsException<NotFoundException>(() => _rechercheVille.Rechercher("a"));
        }
    }
}
