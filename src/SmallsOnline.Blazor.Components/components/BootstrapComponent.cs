using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components
{
    public abstract class BootstrapComponent : ComponentBase, IBootstrapComponent
    {
        [Parameter]
        public string? ClassNames { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
        public string? ClassValue => string.Join(" ", classList);

        public List<string> classList = new();

        public void AddClassNamesToClassList()
        {
            if (string.IsNullOrEmpty(ClassNames) == false)
            {
                classList.Add(ClassNames);
            }
        }
    }
}