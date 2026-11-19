using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int score = 0;
    private bool isPaused = false;

    private void Awake()
    {
        //중복 제거
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        Debug.Log("GameManager 생성 완료");
    }

    //점수 관리
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("현재 점수: " + score);
    }

    //진행 상태 관리
    public void TogglePause()
    {
        isPaused = !isPaused;

        Debug.Log(isPaused ? "게임 일시정지" : "게임 재개");
    }

    public int GetScore()
    {
        return score;
    }
}
