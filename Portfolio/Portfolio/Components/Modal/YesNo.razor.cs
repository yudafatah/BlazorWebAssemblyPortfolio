﻿using Microsoft.AspNetCore.Components;
using Portfolio.Services.Modal;
using System.Threading.Tasks;

namespace Portfolio.Components
{
    public partial class YesNo : Component
    {
        [CascadingParameter]
        public IModal Parent { get; set; }

        [Parameter]
        public string Message { get; set; } = "Are You Sure?";

        protected override Task OnRenderAsync(bool firstRender)
        {
            var message = this.Parent.Options.GetParameterAsString("Message");
            if (!string.IsNullOrEmpty(message)) Message = message;
            return Task.CompletedTask;
        }
        public void Close(bool state)
        {
            if (state) this.Parent.Close(ModalResult.Exit());
            else this.Parent.Close(ModalResult.Cancel());
        }
    }
}
