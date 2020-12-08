using Fluxor;

namespace Portfolio.Stores.MetaTags
{
    public class MetaFeatures : Feature<MetaState>
    {
        public override string GetName() => "GetMeta";
        protected override MetaState GetInitialState() =>
            new MetaState(metaTag: new VM.MetaTag_VM());
    }
}
