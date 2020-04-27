using System;

namespace Python.Runtime
{
    public class ImportEventArgs : EventArgs
    {
        public ImportEventArgs()
        {

        }

        public string ModuleName { get; set; }
    }
}
