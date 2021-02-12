using Microsoft.AspNetCore.Components;
using Portfolio.Services.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Components
{
    public class ViewManager
    {
        /// <summary>
        /// Property referencing the Bootstrap modal instance
        /// </summary>
        public IModal ModalDialog { get; protected set; }

        /// <summary>
        /// Method to open a Modal Dialog
        /// </summary>
        /// <typeparam name="TForm"></typeparam>
        /// <param name="modalOptions"></param>
        /// <returns></returns>
        public async Task<ModalResult> ShowModalAsync<TForm>(ModalOptions modalOptions) where TForm : IComponent => await this.ModalDialog.ShowAsync<TForm>(modalOptions);
    }
}
