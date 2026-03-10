using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CombineMinigame : MonoBehaviour
{
    public Button[] items;
    public TextMeshProUGUI[] checklistItems;
    public int[] correctOrder;

    public Color defaultColor;
    public Color correctColor;
    public Color wrongColor;

    private int currentStep = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnItemClicked(int itemIndex)
    {
        if (itemIndex == correctOrder[currentStep])
        {
            items[itemIndex].image.color = correctColor;
            items[itemIndex].interactable = false;
            checklistItems[currentStep].fontStyle = FontStyles.Strikethrough;
            currentStep++;

            if (currentStep >= correctOrder.Length)
            {
                Debug.Log("Combine section complete");
            }
        }
        else
        {
            StartCoroutine(FlashRed(items[itemIndex].image));
        }
    }

    IEnumerator FlashRed(Image image)
    {
        image.color = wrongColor;
        yield return new WaitForSeconds(0.3f);
        image.color = defaultColor;
    }
}
