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
                "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul", "Valhalla", "Bapettes"
            }
        };

        // Si le texte de la recherche contient moins de 2 caractères, Une exception est levée de type NotFoundException
        [TestMethod]
        public void WhenRecherche_LessThan2_ThrowNotFoundException()
        {
            Assert.ThrowsException<NotFoundException>(() => _rechercheVille.Rechercher("a"));
        }

        // Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous les noms de ville commençant par le texte de recherche exact. Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver
        [TestMethod]
        public void WhenRecherche_EqualOrMoreThan2_ReturnCitiesStartingWithRecherche()
        {
            List<String> actual = _rechercheVille.Rechercher("Va");
            List<String> expected = new List<String>() { "Valence", "Vancouver" };
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        // La fonctionnalité de recherche doit être insensible à la casse
        [TestMethod]
        public void WhenRecherche_CaseInsensitive_ReturnCitiesStartingWithRecherche()
        {
            List<String> actual = _rechercheVille.Rechercher("va");
            List<String> expected = new List<String>() { "Valence", "Vancouver" };
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        // La fonctionnalité de recherche devrait également fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville Par exemple "ape" devrait renvoyer la ville "Budapest"
        [TestMethod]
        public void WhenRecherche_PartOfCityName_ReturnCitiesWithRecherche()
        {
            List<String> actual = _rechercheVille.Rechercher("ape");
            List<String> expected = new List<String>() { "Budapest" };
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        // Si le texte de recherche est un « * » (astérisque), il doit renvoyer tous les noms de ville.
        [TestMethod]
        public void WhenRecherche_Asterisk_ReturnAllCities()
        {
            List<String> actual = _rechercheVille.Rechercher("*");
            List<String> expected = _rechercheVille.Villes;
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
