using UnityEngine;
using UnityEngine.InputSystem;

public class DoorTest : MonoBehaviour
{
    private DoorContext door;

    private void Start()
    {
        door = GetComponent<DoorContext>();
    }

    private void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            door.Operate();
        }
    }
}
