using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrushMinigame : MonoBehaviour
{
    public Image towel;
    public Image hammer;
    public Color flatColor;
    public Color openColor;
    public Color closedColor;
    public Color doneColor;
    public Color hammerIdleColor;
    public Color hammerSwingColor;
    
    private enum TowelState { Flat, Open, Closed, Done }
    private TowelState currentState = TowelState.Flat;
    public Slider progressBar;
    public GameObject crushPanel;
    public GameObject endCrushBtn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if panel is not active, don't do anything
        if (!crushPanel.activeSelf) {
            return;
        }

        // First rolls up the towel
        if (Input.GetMouseButtonDown(0) && currentState == TowelState.Flat)
        {
            currentState = TowelState.Open;
        }

        // If space is held down, towel is held closed
        if (Input.GetKey(KeyCode.Space) && currentState == TowelState.Open)
        {
            currentState = TowelState.Closed;
            towel.color = closedColor;
        }
        
        // If space is not held down, towel is open
        if (Input.GetKeyUp(KeyCode.Space) && currentState == TowelState.Closed)
        {
            currentState = TowelState.Open;
            towel.color = openColor;
        }

        // If left mouse button is clicked while towel is closed, smash objs
        if (Input.GetMouseButtonDown(0) && currentState == TowelState.Closed)
        {
            Debug.Log("Smash");
            progressBar.value += 0.1f;
            StartCoroutine(SwingHammer());


            // Ends Crush section
            if (progressBar.value >= 1f)
            {
                currentState = TowelState.Done;
                towel.color = doneColor;
                endCrushBtn.SetActive(true);
            }
        }
        
        IEnumerator SwingHammer()
        {
            hammer.color = hammerSwingColor;
            yield return new WaitForSeconds(0.2f);
            hammer.color = hammerIdleColor;
        }
        
        // Logs to keep track of TowelState
        if (currentState == TowelState.Flat)
        {
            towel.color = flatColor;
            Debug.Log("Towel is flat");
        }

        if (currentState == TowelState.Open)
        {
            towel.color = openColor;
            Debug.Log("Towel is open");
        }

        if (currentState == TowelState.Closed)
        {
            towel.color = closedColor;
            Debug.Log("Towel is closed");
        }
    }
}
