using UnityEngine;

public class StateDesignTest : MonoBehaviour
{


    void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));

        context.Handle(5);
        context.Handle(11);
        context.Handle(3);
        context.Handle(20);
    }

}
