using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public int moneyPerClick = 1; // Adjust as needed

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }

    private void HandleClick()
    {
        MoneyManager.Instance.AddMoney(moneyPerClick);
    }
}
