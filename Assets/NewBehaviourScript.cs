using UnityEngine;
using Modules.A;
using Modules.B;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var moduleA = new ModuleA();
        moduleA.Log();

        var moduleB = new ModuleB();
        moduleB.Say("Hey");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
