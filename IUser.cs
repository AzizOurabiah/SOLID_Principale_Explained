using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

        void LogError(string error); // ce n'est pas dans la résponsabilité de l'interface IUser
        bool SendEmail(string emailContent); // ce n'est pas dans la résponsabilité de l'interface IUser        
    }
}
