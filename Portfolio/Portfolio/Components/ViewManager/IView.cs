using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Components
{
    public interface IView : IComponent
    {
        public Guid GUID => Guid.NewGuid();

        [CascadingParameter] public ViewManager ViewManager { get; set; }
    }
}
