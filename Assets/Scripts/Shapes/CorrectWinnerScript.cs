using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectWinnerScript : MonoBehaviour {

    public GameObject gmgr;

    // Use this for initialization
    void Start()
    {
        gmgr = GameObject.FindWithTag("GM");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {

            gmgr.GetComponent<GM>().removeLife();
            Debug.Log("hit");
 
        }
        else {

            gmgr.GetComponent<GM>().addScore();

        }


        Destroy(this.gameObject);

    }

}
