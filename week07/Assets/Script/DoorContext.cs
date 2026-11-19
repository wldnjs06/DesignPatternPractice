using UnityEngine;

public class DoorContext : MonoBehaviour
{
    private IDoorState currentState;

    private void Start()
    {
        // 초기 -문이 닫힌 상태
        currentState = new CloseState();

        Debug.Log("초기 상태: 문이 닫혀 있습니다.");
    }

    public void SetState(IDoorState newState)
    {
        currentState = newState;
    }

    public void Operate()
    {
        currentState.Handle(this);
    }
}
