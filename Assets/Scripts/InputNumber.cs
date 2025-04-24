using UnityEngine;
using TMPro;

public class InputNumber : MonoBehaviour
{
    [Header("最大值")]
    public int maxNum = 9;

    [Header("最小值")]
    public int minNum = 0;

    [Header("步長")]
    public int step = 1;

    [Header("顯示用 TextMeshPro")]
    public TextMeshProUGUI displayText;

    [SerializeField, Header("目前值")]
    private int num = 0;

    void Start()
    {
        UpdateDisplay();
    }

    public void Increase()
    {
        num += step;
        if (num > maxNum) num = maxNum;
        UpdateDisplay();
    }

    public void Decrease()
    {
        num -= step;
        if (num < minNum) num = minNum;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (displayText != null)
            displayText.text = num.ToString();
    }
}
