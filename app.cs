using Stormancer;
using System.Threading.Tasks;

namespace Server
{
    public class App
    {
        public void Run(Stormancer.IAppBuilder builder)
        {
            builder.SceneTemplate("helloworld-template", scene => {

                //Add a procedure named "hello" to the scene.
                scene.AddProcedure("hello", ctx => {

                    //Send the string "Hello world!" to the caller.
                    ctx.SendValue("Hello world!");

                    return Task.FromResult(true);
                });
            });
        }
    }
}