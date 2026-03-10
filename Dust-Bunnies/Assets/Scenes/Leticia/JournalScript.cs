using UnityEngine;

public class JournalScript : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPg = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void flipPage()
    {
        pages[currentPg].SetActive(false);
        currentPg++;
        if (currentPg < pages.Length)
        {
            Debug.Log("Page flipped");
            pages[currentPg].SetActive(true);
        }
        else
        {
            Debug.Log("Reached end of journal.");
        }
    }
}
