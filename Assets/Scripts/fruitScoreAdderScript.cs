using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fruitScoreAdderScript : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;

public GameObject lController, rController;
    private fruitScoreScriptLeft fScoreLeft;
    private fruitScoreScriptRight fScoreRight;

    private int totalScore = 0, lScore, rScore;

    void Start()
    {
        Debug.Log("Adder Script Started");
        fScoreLeft = lController.GetComponent<fruitScoreScriptLeft>();
        fScoreRight = rController.GetComponent<fruitScoreScriptRight>();
    }

    void Update()
    {
        lScore = fScoreLeft.lScore;
        rScore = fScoreRight.rScore;
        totalScore = lScore + rScore;
        scoreUI.text = "Fruits Collected: " + totalScore;
    }
}