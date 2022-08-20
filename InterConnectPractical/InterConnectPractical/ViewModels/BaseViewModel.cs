using InterConnectPractical.Shared.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace InterConnectPractical.ViewModels
{
    public class BaseViewModel : ObservableModel
    {
        public void WriteExceptionToLog(Exception e, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string callerfile = null, [CallerMemberName] string caller = null)
        {
            Debug.WriteLine("Exception thrown in: " + callerfile + " at position- Line No:" + lineNumber + ", Caller Member:" + caller + ", Message:" + e.Message);
            Debug.WriteLine(e.StackTrace);
        }
        public bool IsInitialized { get; set; }
    }
}
