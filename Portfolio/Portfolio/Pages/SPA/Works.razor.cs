using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Portfolio.Pages.Contents.Works;

namespace Portfolio.Pages.SPA
{
    public partial class Works
    {
        // pass classname parameter
        [Parameter] public string ClassName { get; set; }

        // call Modal
        [CascadingParameter] public IModalService Modal { get; set; }

        void ShowModalEWS()
        {
            var opt = new ModalOptions()
            {
                ContentScrollable = true,
                FocusFirstElement = true
            };

            Modal.Show<EWS>("Early Warning System", opt);
        }

        void ShowModalDigisales()
        {
            var opt = new ModalOptions()
            {
                ContentScrollable = true,
                FocusFirstElement = true
            };

            Modal.Show<Digisales>("Digisales", opt);
        }
    }
}
