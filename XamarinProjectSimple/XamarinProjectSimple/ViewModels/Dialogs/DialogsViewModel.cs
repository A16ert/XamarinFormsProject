using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinProjectSimple.Models.DialogModels;
using XamarinProjectSimple.Services.Dialogs;

namespace XamarinProjectSimple.ViewModels.Dialogs
{
    public class DialogsViewModel : BaseViewModel
    {
        public ObservableCollection<DialogShortModel> DialogsList
        {
            get => _dialogsList;

            private set
            {
                _dialogsList = value;
                OnPropertyChanged();
            }
        }

        public Command DeleteCommand { get; private set; }

        public DialogsViewModel()
        {
            dialogService = DependencyService.Get<IDialogsService>();

            DialogsList = dialogService.GetAll();

            DeleteCommand = new Command(DeleteDialog);
        }

        private IDialogsService dialogService;

        private ObservableCollection<DialogShortModel> _dialogsList;

        private void DeleteDialog(object Message)
        {
            _dialogsList.Remove(Message as DialogShortModel);

            dialogService.DeleteDialog();
        }
    }
}
