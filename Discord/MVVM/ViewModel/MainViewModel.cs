using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Discord.MVVM.Model;

namespace Discord.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            { 
                Username = "Allison",
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
                    Username = "Allison",
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
                    UserName = $"Allison {i}",
                    ImageSource = "https://i.imgur.com/8OyzSQb.gif",
                    Messages = Messages
                });
            }
        }

    }
}
