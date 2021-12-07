using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.Tables
{
    public partial class SimpleTable : BootstrapComponent
    {
        [Parameter]
        public string? Title { get; set; }

        protected override void OnParametersSet()
        {
            AddClassNamesToClassList();
        }
    }
}