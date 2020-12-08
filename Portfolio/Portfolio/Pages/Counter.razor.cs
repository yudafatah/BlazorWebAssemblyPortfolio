using Fluxor;
using Microsoft.AspNetCore.Components;
using Portfolio.Stores.MetaTags;
using Portfolio.Stores.MetaTags.VM;

namespace Portfolio.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<MetaState> _metaState { get; set; }
        [Inject]
        public IDispatcher _dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var data = new MetaTag_VM()
            {
                Author = "a",
                Description = "b",
                Keywords = "c",
                Title = "d"
            };
            _dispatcher.Dispatch(new PageChangeAction(data));

        }
    }
}
