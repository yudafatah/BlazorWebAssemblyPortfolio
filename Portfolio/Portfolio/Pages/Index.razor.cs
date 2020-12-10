using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public partial class Index
    {
        string ActiveCard { get; set; } = "about";

        void SetCard(string name)
        {
            ActiveCard = name;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        async Task GetDimensions()
        {
            var dimension = await Service.GetDimensions();
            Height = dimension.Height;
            Width = dimension.Width;
        }

        protected override async Task OnInitializedAsync()
        {
            await GetDimensions();
            StateHasChanged();
        }
    }
}
