using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClickSpeed : MonoBehaviour
{
    private float lastClickTime;

    public Button button;
    public TMP_Text text;

    public Clicker clicker;

    private void Start()
    {
        button.onClick.AddListener(CalculateClickSpeed);
    }

    private void CalculateClickSpeed()
    {
        float currentClickTime = Time.time;
        
        float score = clicker.CurrentScore;

        if (lastClickTime > 0)
        {
            float clickSpeed = currentClickTime - lastClickTime;

            // Calculate the score increase per second based on the click speed and 5% of the current score
            float scoreIncreasePerSecond = Mathf.Clamp(score * 0.01f / clickSpeed, -Mathf.Infinity, Mathf.Infinity);

            // Update the UI text with the calculated score per second
            text.text = $"{scoreIncreasePerSecond:F2} / sec";

            Debug.Log($"Click Speed: {clickSpeed}, Score Increase Per Second: {scoreIncreasePerSecond:F2}");
        }

        lastClickTime = currentClickTime;
    }
}
