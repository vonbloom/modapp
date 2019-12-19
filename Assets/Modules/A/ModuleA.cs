using Modules.B;

namespace Modules.A
{
    public class ModuleA
    {
        public void Log()
        {
            var moduleB = new ModuleB();
            moduleB.Say("Hello");
        }
    }
}