using UnityEngine;

public class PatternMinigame : MonoBehaviour
{
    public PatternSelector centerPattern;
    public PatternSelector basePattern;
    public PatternSelector detailPattern;

    public Vector3Int[] levels; //stores the correct combination for each level
    private int currentLevel = 0;
    
    public GameObject endDesignBtn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer()
    {
        Vector3Int correct = levels[currentLevel];

        if (centerPattern.GetCurrentIndex() == correct.x &&
            basePattern.GetCurrentIndex() == correct.y &&
            detailPattern.GetCurrentIndex() == correct.z)
        {
            Debug.Log("Correct");
            currentLevel++;

            if (currentLevel >= levels.Length)
            {
                Debug.Log("Design phase complete");
                endDesignBtn.SetActive(true);
            }
            else
            {
                centerPattern.Reset();
                basePattern.Reset();
                detailPattern.Reset();
                Debug.Log("Next level");
            }
        }
        else
        {
            Debug.Log("Wrong");
        }
    }
}
