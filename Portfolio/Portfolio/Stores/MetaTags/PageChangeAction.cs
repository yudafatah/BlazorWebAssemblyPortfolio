using Portfolio.Stores.MetaTags.VM;

namespace Portfolio.Stores.MetaTags
{
    public class PageChangeAction
    {
        public MetaTag_VM MetaTag { get; }
        public PageChangeAction(MetaTag_VM metaTag)
        {
            MetaTag = metaTag;
        }
    }
}
