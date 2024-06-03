using Microsoft.AspNetCore.Components;

namespace Exercice1.Pages
{
    public partial class ComposantEnfant
    {
        [Parameter]
        public string Name { get; set; } = "";
        [Parameter]
        public EventCallback<List<string>> RetourEnfant { get; set; }

        public bool Visible { get; set; } = false;

        public int IndexQuestion { get; set; } = 0;
        public string Question { get; set; } = "";
        public List<string> Questions { get; set; } = new List<string>() { "Question 1", "Question 2" };

        public List<string> Reponses { get; set; } = new List<string>();

        protected override void OnInitialized()
        {
            Visible = false;
        }

        protected override async Task OnParametersSetAsync()
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                Visible = true;
                Reponses.Add($"Les réponses de {Name} sont :");
                Question = Questions[IndexQuestion];
            }
        }

        private void Add(bool response)
        {
            Reponses.Add(response ? "Oui" : "Non");

            if (IndexQuestion >= Questions.Count - 1)
            {
                RetourEnfant.InvokeAsync(Reponses);
                Reponses.Clear();
                IndexQuestion = 0;
                Visible = false;
                Name = string.Empty;
            }
            else
            {
                IndexQuestion++;
                Question = Questions[IndexQuestion];
            }
        }
    }
}
