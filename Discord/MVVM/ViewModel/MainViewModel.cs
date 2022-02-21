using System;
using Discord.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Discord.MVVM.Model;

namespace Discord.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }
        public ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            {
                _message = value;
                OnPropertyChanged(); 
            }
            
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o => 
            {
                Messages = new ObservableCollection<MessageModel>();
                Contacts = new ObservableCollection<ContactModel>();

                SendCommand = new RelayCommand(o => 
                {
                    Messages.Add(new MessageModel {
                        
                    Message = Message,
                    FirstMessage = false
                    });

                    Message = "";
                });

            });


            Messages.Add(new MessageModel
            { 
                Username = "식빵",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/DBMRyNF.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for(int i=0;i<3;++i)
            {
                Messages.Add(new MessageModel
                {
                    Username = "딸기식빵",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/DBMRyNF.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; ++i)
            {
                Messages.Add(new MessageModel
                {
                    Username = "LHJ",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/DBMRyNF.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "LHJ",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/DBMRyNF.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });


            for (int i = 0; i < 5; ++i)
            {
                Contacts.Add(new ContactModel{
                    UserName = $"식빵 {i}",
                    ImageSource = "https://i.imgur.com/8OyzSQb.gif",
                    Messages = Messages
                });
            }
        }

    }
}
