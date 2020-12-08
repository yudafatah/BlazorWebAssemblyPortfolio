using Portfolio.Stores.MetaTags.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
