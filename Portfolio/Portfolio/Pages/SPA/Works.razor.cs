using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Portfolio.Pages.Contents.Works;
using System.Collections.Generic;

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

            Modal.Show<EWS>("", opt);
        }

        // Image Slider
        IList<Item> items = new List<Item>
        {
            new Item
            {
                Alt="EWS",
                Caption = "Early Warning System App",
                Header="",
                Source = ""
            }
        };

        class Item
        {
            public string Source { get; set; } = "";
            public string Alt { get; set; } = "";
            public string Caption { get; set; } = "";
            public string Header { get; set; } = "";
        }
    }
}
