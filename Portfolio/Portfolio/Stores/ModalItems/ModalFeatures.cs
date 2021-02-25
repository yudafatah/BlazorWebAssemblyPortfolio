using Fluxor;
using Portfolio.ViewModels;

namespace Portfolio.Stores.ModalItems
{
    public class ModalFeatures : Feature<ModalState>
    {
        public override string GetName() => "GetModal";
        protected override ModalState GetInitialState() =>
            new ModalState(appName: new AppNameVM());
    }
}
