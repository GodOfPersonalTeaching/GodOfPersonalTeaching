using System;
using System.Threading.Tasks;

namespace GodOfPersonalTeaching.Services.Dialog
{
    public interface IDalogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
