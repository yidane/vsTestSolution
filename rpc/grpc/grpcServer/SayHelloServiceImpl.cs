using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using SayHello;

namespace grpcServer
{
    public class SayHelloServiceImpl : SayHello.UserService.UserServiceBase
    {
        public override Task<User> GetUser(UserRequest request, ServerCallContext context)
        {
            //return new Task<User>(delegate ()
            //{
            //    return new User()
            //    {
            //        UserID = 1,
            //        UserName = "yidane"
            //    };
            //});

            return Task.Run<User>(delegate ()
            {
                return new User()
                {
                    UserID = 1,
                    UserName = "yidane"
                };
            });

            return Task.FromResult<User>(new User()
            {
                UserID = 1,
                UserName = "yidane"
            });
        }
    }
}
