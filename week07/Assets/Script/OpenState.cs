using UnityEngine;

public class OpenState : IDoorState
{
    public void Handle(DoorContext context)
    {
        Debug.Log("문이 닫힙니다.");

        context.SetState(new CloseState());
    }
}
