using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.Cards
{
    public partial class ItemCard : BootstrapComponent
    {
        [Parameter]
        public RenderFragment? TitleSection { get; set; }

        [Parameter]
        public string? TitleSubtitle { get; set; }

        [Parameter]
        public RenderFragment? FooterSection { get; set; }

        protected override void OnParametersSet()
        {
            classList.Add("card");
            AddClassNamesToClassList();
        }
    }
}