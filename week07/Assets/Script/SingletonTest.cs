using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    private void Start()
    {
        //점수 관리
        GameManager.Instance.AddScore(100);
        GameManager.Instance.AddScore(50);

        //일시정지 및 재시작
        GameManager.Instance.TogglePause();
        GameManager.Instance.TogglePause();

        Debug.Log("최종 점수: " + GameManager.Instance.GetScore());
    }
}