using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Services.Modal
{
    public interface IModal
    {
        ModalOptions Options { get; set; }

        // Method to display a Modal Dialog
        Task<ModalResult> ShowAsync<TModal>(ModalOptions options) where TModal : IComponent;

        // Method to update the Modal Dialog during display
        void Update(ModalOptions options = null);

        // Method to dismiss - normally called by the dismiss button in the header bar
        void Dismiss();

        // Method to close the dialog - normally called by the child component TModal
        void Close(ModalResult result);
    }
}
