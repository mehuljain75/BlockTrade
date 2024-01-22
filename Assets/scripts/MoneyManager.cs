using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }

    public TMP_Text moneyText;
    private float money;

    // Rate at which money increases per second
    public float moneyPerSecond = 0.002f;

    private void Awake()
    {
        Instance = this;
        money = 0;
    }

    private void FixedUpdate()
    {
        // Call a method to increase money over time
        IncreaseMoneyOverTime();
    }

    private void UpdateMoneyText()
    {
        moneyText.text = "$" + money.ToString();
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UpdateMoneyText();
    }

    // Method to increase money over time
    private void IncreaseMoneyOverTime()
    {
        money += moneyPerSecond * Time.deltaTime;
        UpdateMoneyText();
    }
}
    