using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.Cards
{
    public partial class PageContentCard : BootstrapComponent
    {
        [Parameter]
        public string? PageTitle { get; set; }

        [Parameter]
        public string? Id { get; set; }

        protected override void OnParametersSet()
        {
            AddClassNamesToClassList();
        }
    }
}