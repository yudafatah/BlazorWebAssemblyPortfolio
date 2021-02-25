using Fluxor;
using Microsoft.AspNetCore.Components;
using Portfolio.Stores.ModalItems;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio.Pages.Contents.Works
{
    public partial class WorkDetails
    {
        [Parameter] public string appName { get; set; } = "xxx";

        // Get AppName state
        [Inject]
        private IState<ModalState> _modalState { get; set; }

        // Image Slider
        IList<ImageSliderVM> items = new List<ImageSliderVM>();

        // Content
        WorkDetVM cnt = new WorkDetVM();

        protected override async Task OnInitializedAsync()
        {
            // reset
            items = new List<ImageSliderVM>();

            // fetch data workdetails
            var res = await Http.GetFromJsonAsync<WorkDetVM[]>("sample-data/workdetails.json");
            cnt = res.Where(x=>x.AppName.Equals(_modalState.Value._appName.appName.ToString().ToUpper()))
                .FirstOrDefault();

            // fetch list data Images
            var res1 = await Http.GetFromJsonAsync<ImageSliderVM[]>("sample-data/workDetImages.json");
            var res2 = res1.Where(x => x.AppName.Equals(_modalState.Value._appName.appName.ToString().ToUpper())).ToList();

            foreach(var i in res2)
            {
                items.Add(i);
            }

            //StateHasChanged();
        }
    }
}
