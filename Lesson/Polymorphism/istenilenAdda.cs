using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class istenilenAdda
    {
        string FriendName;

        public istenilenAdda(string _FriendName)
        {
            FriendName = _FriendName;
        }

        public void GreetFriend()
        {
            //Hi Kamil,my friend!
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hi {FriendName}, my friend");
            Console.WriteLine( sb.ToString() );
        }
    }
}
