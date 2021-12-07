using Microsoft.AspNetCore.Components;


namespace SmallsOnline.Blazor.Components
{
    public interface IBootstrapComponent
    {
        string? ClassNames { get; set; }
        RenderFragment? ChildContent { get; set; }
    }
}