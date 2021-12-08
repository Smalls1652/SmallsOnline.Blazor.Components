using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.ListGroups
{
    public partial class SimpleListGroupItem : BootstrapComponent
    {
        protected override void OnParametersSet()
        {
            AddClassNamesToClassList();
        }
    }
}