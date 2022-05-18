using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class Member : IMember
    {
        public string Name { get; set; }
        private readonly IFacebookGroup mediator;

        public Member(string name, IFacebookGroup mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public void Publish(string message)
        {
            Console.WriteLine($"{Name} has published post with the message:\n'{message}'");
            mediator.SendMessageToUsers(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} received the message:\n'{message}'");
        }
    }
}
