using System;
using Google.Protobuf;

namespace CsharpProtobuf
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginPacket = new LoginPacket
            {
                Code = 0x01,
                Size = 29,
                SizeOfUsername = 8,
                Username = "imkk-000",
                SizeOfPassword = 13,
                Password = "p@55w0rd1234*",
            };
            // convert it to bytes
            System.IO.File.WriteAllBytes("send.bin", loginPacket.ToByteArray());
        }
    }
}
