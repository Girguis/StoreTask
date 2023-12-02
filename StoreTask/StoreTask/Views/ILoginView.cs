using System;

namespace StoreTask.Views
{
    public interface ILoginView
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Message { get; set; }

        void CloseForm();

        event EventHandler LoginEvent;
        event EventHandler ClearEvent;
        event EventHandler ExitEvent;

    }
}
