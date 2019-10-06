using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI trickText;
    [SerializeField] GameObject higherButton;
    [SerializeField] GameObject lowerButton;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        trickText.GetComponent<CanvasGroup>().alpha = 0f;
        max += 1;
    }

    public void onPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }

    public void NextGuess()
    {
        if (min == max)
        {
            trickText.GetComponent<CanvasGroup>().alpha = 1f;
            higherButton.SetActive(false);
            lowerButton.SetActive(false);

        }
        else { 
            guess = Random.Range(min, max);
            guessText.text = guess.ToString();
            //Debug.Log("min: " + min + ", max: " + max);
        }
    }
}
