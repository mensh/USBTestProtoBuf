using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBTestProtoBuf
{
    class Program
    {

        [ProtoContract]
        class SimpleMessage
        {
            [ProtoMember(1)]
            public int lucky_number { get; set; }
        }


        static void Main(string[] args)
        {
            SimpleMessage simpleMessage = new SimpleMessage();
            simpleMessage.lucky_number = 1;
            var fs = File.Create("data.dat");
            Serializer.Serialize(fs,simpleMessage);

        }
    }
}
