using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectWinnerScript : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {

        Destroy(this.gameObject);

    }

}
