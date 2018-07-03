using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinProjectSimple.Models.DialogModels;

namespace XamarinProjectSimple.Services.Dialogs
{
    public interface IDialogsService
    {
        ObservableCollection<MessageModel> GetDialog(int id);

        ObservableCollection<DialogShortModel> GetAll();

        void DeleteDialog();

        void SendMessage(string message);
    }
}
