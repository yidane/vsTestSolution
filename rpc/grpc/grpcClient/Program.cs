using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Grpc.Core.Channel channel = new Grpc.Core.Channel("127.0.0.1:5050", Grpc.Core.ChannelCredentials.Insecure);
            SayHello.UserService.UserServiceClient client = new SayHello.UserService.UserServiceClient(channel);


            Console.WriteLine("begin get user");
            var user = client.GetUser(new SayHello.UserRequest());

            Console.WriteLine(user.UserID);

            Console.WriteLine(user);

            Console.WriteLine("end get user");

            Console.ReadKey();
        }
    }
}
