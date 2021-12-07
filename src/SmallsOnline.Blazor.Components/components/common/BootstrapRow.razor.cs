using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.Common
{
    public partial class BootstrapRow : BootstrapComponent
    {
        [Parameter]
        public int? HorizontalGutters { get; set; }

        [Parameter]
        public int? VerticalGutters { get; set; }

        protected override void OnParametersSet()
        {

            classList.Add("row");

            if (HorizontalGutters != null)
            {
                classList.Add($"gx-{HorizontalGutters}");
            }

            if (VerticalGutters != null)
            {
                classList.Add($"gy-{VerticalGutters}");
            }

            AddClassNamesToClassList();
        }

    }
}