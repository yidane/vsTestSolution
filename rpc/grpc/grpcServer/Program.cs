using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 5050;
            Grpc.Core.Server server = new Grpc.Core.Server()
            {
                Services = { SayHello.UserService.BindService(new SayHelloServiceImpl()) },
                Ports = { new Grpc.Core.ServerPort("127.0.0.1", port, Grpc.Core.ServerCredentials.Insecure) }
            };

            server.Start();

            Console.WriteLine("RouteGuide server listening on port " + port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            //server.ShutdownAsync().Wait();
        }
    }
}
