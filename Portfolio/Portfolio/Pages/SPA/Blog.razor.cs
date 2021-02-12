using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;

namespace Portfolio.Pages.SPA
{
    public partial class Blog
    {
        [Parameter]
        public string ClassName { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }
    }
}
