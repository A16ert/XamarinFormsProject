using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinProjectSimple.Models.DialogModels;
using XamarinProjectSimple.Services.Dialogs;

namespace XamarinProjectSimple.ViewModels.Dialogs
{
    class DialogDetailViewModel : BaseViewModel
    {
        public string CompanionName { get; private set; }

        public ObservableCollection<MessageModel> MessagesList
        {
            get => _messagesList;

            set
            {
                _messagesList = value;
                OnPropertyChanged();
            }
        }

        public string NewMessage
        {
            get => _newMessage;
            set
            {
                _newMessage = value;
                OnPropertyChanged();
            }
        }

        public Command SendMessageCommand { get; private set; }


        public DialogDetailViewModel()
        {
            dialogsServilce = DependencyService.Get<IDialogsService>();

            MessagesList = dialogsServilce.GetDialog(0);

            SendMessageCommand = new Command(SendMessage);
        }

        private IDialogsService dialogsServilce;
        
        private string _newMessage = string.Empty;

        private ObservableCollection<MessageModel> _messagesList;

        private void SendMessage()
        {
            _messagesList.Add(new MessageModel() { Text = _newMessage, IsMyMessage = true });

            NewMessage = string.Empty;
        }
    }
}
