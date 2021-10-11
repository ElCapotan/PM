using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxGuess = 1000;
    [SerializeField] int minGuess = 1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        NextGuess();
    }

    public void OnPressHigher()
    {
        minGuess = guess +1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxGuess = guess -1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(maxGuess, minGuess);
        guessText.text = guess.ToString();
    }
}
