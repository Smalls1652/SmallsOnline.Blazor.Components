using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.ListGroups
{
    public partial class SimpleListGroup : BootstrapComponent
    {
        [Parameter]
        public bool Flush { get; set; } = false;

        private string? ListGroupClassValue;

        protected override void OnParametersSet()
        {
            List<string> listGroupClasses = new();
            listGroupClasses.Add("list-group");

            if (Flush)
            {
                listGroupClasses.Add("list-group-flush");
            }

            ListGroupClassValue = string.Join(" ", listGroupClasses);

            AddClassNamesToClassList();
        }
    }
}