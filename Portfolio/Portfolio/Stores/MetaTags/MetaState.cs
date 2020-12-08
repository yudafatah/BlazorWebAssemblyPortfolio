using Portfolio.Stores.MetaTags.VM;

namespace Portfolio.Stores.MetaTags
{
    public class MetaState
    {
        public MetaTag_VM _metaTag { get; }

        public MetaState(MetaTag_VM metaTag)
        {
            _metaTag = metaTag?? new MetaTag_VM();
        }
    }
}
