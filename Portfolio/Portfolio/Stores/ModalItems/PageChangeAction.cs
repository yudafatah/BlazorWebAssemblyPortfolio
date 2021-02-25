using Portfolio.ViewModels;

namespace Portfolio.Stores.ModalItems
{
    public class ModalPageChangeAction
    {
        public AppNameVM AppName { get; }
        public ModalPageChangeAction(AppNameVM appName)
        {
            AppName = appName;
        }
    }
}
