using Microsoft.AspNetCore.Components;

namespace SmallsOnline.Blazor.Components.Common
{
    public partial class BootstrapCol : BootstrapComponent
    {
        [Parameter]
        public int? XS { get; set; }

        [Parameter]
        public int? SM { get; set; }

        [Parameter]
        public int? MD { get; set; }

        [Parameter]
        public int? LG { get; set; }

        [Parameter]
        public int? XL { get; set; }

        [Parameter]
        public int? XXL { get; set; }

        protected override void OnParametersSet()
        {
            if ((XS == null) && (SM == null) && (MD == null) && (LG == null) && (XL == null) && (XXL == null))
            {
                classList.Add("col");
            }
            else
            {
                if (XS != null)
                {
                    classList.Add($"col-{XS}");
                }

                if (SM != null)
                {
                    classList.Add($"col-sm-{SM}");
                }

                if (MD != null)
                {
                    classList.Add($"col-md-{MD}");
                }

                if (LG != null)
                {
                    classList.Add($"col-lg-{LG}");
                }

                if (XL != null)
                {
                    classList.Add($"col-xl-{XL}");
                }

                if (XXL != null)
                {
                    classList.Add($"col-xxl-{XXL}");
                }
            }

            AddClassNamesToClassList();
        }
    }
}