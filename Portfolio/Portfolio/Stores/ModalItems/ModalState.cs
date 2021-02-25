using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Stores.ModalItems
{
    public class ModalState
    {
        public AppNameVM _appName { get; }

        public ModalState(AppNameVM appName)
        {
            _appName = appName ?? new AppNameVM();
        }
    }
}
