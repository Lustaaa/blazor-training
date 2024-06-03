using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace Exercice1.Pages
{
    public partial class ComposantParent
    {
        public string Name { get; set; }

        public List<string> ReponseEnfants { get; set; } = new List<string>();

        public void RetourEnfant(List<string> reponse)
        {
            Name = string.Empty;
            ReponseEnfants.Clear();
            reponse.ForEach(r => { ReponseEnfants.Add(r); });
        }
    }
}
