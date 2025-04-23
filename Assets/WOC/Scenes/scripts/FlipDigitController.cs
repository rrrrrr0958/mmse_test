using TMPro;
using UnityEngine;

public class FlipDigitController : MonoBehaviour
{
    public GameObject[] pages;
    private int currentIndex = 0;

    public void Increment()
    {
        pages[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % pages.Length;
        pages[currentIndex].SetActive(true);
    }

    public void Decrement()
    {
        pages[currentIndex].SetActive(false);
        currentIndex = (currentIndex - 1 + pages.Length) % pages.Length;
        pages[currentIndex].SetActive(true);
    }

    void Start()
    {
        for (int i = 0; i < pages.Length; i++)
            pages[i].SetActive(i == currentIndex);
    }
}
