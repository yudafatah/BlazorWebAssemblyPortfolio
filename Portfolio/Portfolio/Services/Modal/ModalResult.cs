using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Services.Modal
{
    public class ModalResult
    {
        // The closing type
        public ModalResultType ResultType { get; private set; } = ModalResultType.NoSet;

        // Whatever object you wish to pass back
        public object Data { get; set; } = null;

        // A set of static methods to build a BootstrapModalResult

        public static ModalResult OK() => new ModalResult() { ResultType = ModalResultType.OK };

        public static ModalResult Exit() => new ModalResult() { ResultType = ModalResultType.Exit };

        public static ModalResult Cancel() => new ModalResult()
        { ResultType = ModalResultType.Cancel };

        public static ModalResult OK(object data) => new ModalResult()
        { Data = data, ResultType = ModalResultType.OK };

        public static ModalResult Exit(object data) => new ModalResult()
        { Data = data, ResultType = ModalResultType.Exit };

        public static ModalResult Cancel(object data) => new ModalResult()
        { Data = data, ResultType = ModalResultType.Cancel };
    }
}
