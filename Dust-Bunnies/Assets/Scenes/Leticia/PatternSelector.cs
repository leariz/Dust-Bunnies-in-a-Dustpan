using UnityEngine;
using UnityEngine.UI;

public class PatternSelector : MonoBehaviour
{
    public Image selectionImage;
    public Color[] patternOptions;
    private int currentIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectionImage.color = patternOptions[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        currentIndex = (currentIndex + 1) % patternOptions.Length;
        selectionImage.color = patternOptions[currentIndex];
    }

    public int GetCurrentIndex()
    {
        return currentIndex;
    }

    public void Reset()
    {
        currentIndex = 0;
        selectionImage.color = patternOptions[0];
    }
}
