using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace ColorPicker
{
    public class ShellViewModel : ReactiveObject
    {
        public ShellViewModel()
        {
            //var canQuitApplication;

        }

        public ReactiveCommand<Unit, Unit> QuitApplication { get; private set; }
    }
}
