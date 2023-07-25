using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countdownDuration = 60f;
    private float currentTime;
    private bool isCountingDown = false;
    private Text countdownText;

    void Start()
    {
        countdownText = GetComponent<Text>();
        ResetTimer();
    }

    void Update()
    {
        if (isCountingDown)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();

            if (currentTime <= 0f)
            {
                currentTime = 0f;
                isCountingDown = false;
                // Handle timer completion here
            }
        }
    }

    public void StartTimer()
    {
        isCountingDown = true;
    }

    public void ResetTimer()
    {
        currentTime = countdownDuration;
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        countdownText.text = currentTime.ToString("F2");
    }
}
