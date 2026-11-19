using UnityEngine;

public class CloseState : IDoorState
{
    public void Handle(DoorContext context)
    {
        Debug.Log("문이 열립니다.");

        context.SetState(new OpenState());
    }
}