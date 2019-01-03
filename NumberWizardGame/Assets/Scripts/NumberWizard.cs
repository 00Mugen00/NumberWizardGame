using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField]
    int max;
    [SerializeField]
    int min;
    [SerializeField]
    TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        NextGuess();
        max = max + 1;
    }


    public void OnPressHigher()
    {
        max = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = "Are you thinking about " + guess.ToString() + "?";
    }
}
