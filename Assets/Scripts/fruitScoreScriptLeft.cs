using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fruitScoreScriptLeft : MonoBehaviour
{

    public int lScore = 0;

    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == "fruit")
        {
            // If the GameObject has the same tag as specified, increase the score
            lScore++;
            Destroy(coll.gameObject);
            Debug.Log("Left Score: " + lScore);

        }   
    }
}
