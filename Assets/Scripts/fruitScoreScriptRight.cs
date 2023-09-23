using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScoreScriptRight : MonoBehaviour
{

    public int rScore = 0;

    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == "fruit")
        {
            // If the GameObject has the same tag as specified, increase the score
            rScore++;
            Destroy(coll.gameObject);
            Debug.Log("Right Score: " + rScore);

        }   
    }
}
