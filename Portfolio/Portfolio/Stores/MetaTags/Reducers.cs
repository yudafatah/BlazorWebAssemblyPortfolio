using Fluxor;

namespace Portfolio.Stores.MetaTags
{
    public class Reducers
    {
        [ReducerMethod]
        public static MetaState ReducePageChangeAction(MetaState state, PageChangeAction action) =>
            new MetaState(metaTag: action.MetaTag);
    }
}
