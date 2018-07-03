using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinProjectSimple.Models.DialogModels;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinProjectSimple.Services.Dialogs.DialogService))]

namespace XamarinProjectSimple.Services.Dialogs
{
    public class DialogService : IDialogsService
    {
        public ObservableCollection<DialogShortModel> GetAll()
        {
            return new ObservableCollection<DialogShortModel>()
            {
                new DialogShortModel() { Name = "mergen", LastMessage = "Ваша скидка увеличилась", Date = "19.09.2017"},
                new DialogShortModel() { Name = "ООО Тест", LastMessage = "Ваша скидка увеличилась", Date = "21.09.2017"},
                new DialogShortModel() { Name = "Тесе2", LastMessage = "Ваша скидка увеличилась", Date = "19.09.2017"}
            };
        }

        public ObservableCollection<MessageModel> GetDialog(int id)
        {
            return new ObservableCollection<MessageModel>
            {
                new MessageModel(){ Text = "Item 1", IsMyMessage = true},
                new MessageModel(){ Text = "Item 2"},
                new MessageModel(){ Text = "Item 3"},
                new MessageModel(){ Text = "Item 4", IsMyMessage = true},
                new MessageModel(){ Text = "Item 5" }
            };
        }

        public void DeleteDialog()
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
