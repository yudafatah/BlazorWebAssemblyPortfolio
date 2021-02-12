using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    public class ViewBase : Component, IView
    {
        [CascadingParameter]
        public ViewManager ViewManager { get; set; }
    }
}
