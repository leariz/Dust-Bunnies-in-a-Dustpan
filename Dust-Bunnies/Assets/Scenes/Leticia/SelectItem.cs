using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public int itemIndex;
    public CombineMinigame combineMinigame;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        combineMinigame.OnItemClicked(itemIndex);
    }
}
