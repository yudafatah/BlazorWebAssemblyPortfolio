using Fluxor;
using Microsoft.AspNetCore.Components;
using Portfolio.Stores.ModalItems;
using Portfolio.ViewModels;
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
        List<ImageSliderVM> items = new List<ImageSliderVM>();

        // Content
        WorkDetVM cnt = new WorkDetVM();

        protected override async Task OnInitializedAsync()
        {
            // fetch data workdetails
            var res = await Http.GetFromJsonAsync<WorkDetVM[]>("sample-data/workdetails.json");
            cnt = res.Where(x=>x.AppName.Equals(_modalState.Value._appName.appName.ToString().ToUpper()))
                .FirstOrDefault();

            // fetch list data Images
            var res1 = await Http.GetFromJsonAsync<ImageSliderVM[]>("sample-data/workDetImages.json");
            items.AddRange(res1.Where(x => x.AppName.Equals(_modalState.Value._appName.appName.ToString().ToUpper())).ToList());

            StateHasChanged();
        }
    }
}
