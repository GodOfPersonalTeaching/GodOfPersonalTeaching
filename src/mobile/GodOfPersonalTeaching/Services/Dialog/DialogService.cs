using System;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace GodOfPersonalTeaching.Services.Dialog
{
    public class DialogService : IDalogService
    {
        public Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }
    }
}
