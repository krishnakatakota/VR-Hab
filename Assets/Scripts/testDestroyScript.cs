using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testDestroyScript : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "testCol")
            {
                //If the GameObject has the same tag as specified, output this message in the console
                Destroy(coll.gameObject);
            }   
        }
}
