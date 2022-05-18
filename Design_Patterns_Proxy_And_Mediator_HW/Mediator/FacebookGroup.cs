using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class FacebookGroup : IFacebookGroup
    {
        List<IMember> members;
        public FacebookGroup()
        {
            members = new List<IMember>();
        }
        public void RegisterUser(IMember member)
        {
            members.Add(member);
        }

        public void SendMessageToUsers(string message, IMember member)
        {
            members.ForEach(m =>
            {
                if (m != member)
                    m.Receive(message);
            });
        }
    }
}
