using Fluxor;

namespace Portfolio.Stores.ModalItems
{
    public class Reducer
    {
        [ReducerMethod]
        public static ModalState ReducePageChangeAction(ModalState state, ModalPageChangeAction action) =>
            new ModalState(appName: action.AppName);
    }
}
