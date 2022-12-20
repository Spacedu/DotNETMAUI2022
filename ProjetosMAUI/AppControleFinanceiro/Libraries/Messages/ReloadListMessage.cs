using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Libraries.Messages
{
    public class ReloadListMessage : ValueChangedMessage<string>
    {
        public ReloadListMessage(string value) : base(value)
        {
        }
    }
}
