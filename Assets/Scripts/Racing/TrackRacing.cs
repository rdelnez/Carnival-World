using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRacing : MonoBehaviour {

    public int moveToThisY;
    public float speedY;
   

	// Use this for initialization
	void Start () {
        speedY = -6.0f;
        moveToThisY = -100;
        

        StartCoroutine("MoveRaceTrack");
	}

    IEnumerator MoveRaceTrack()

    {
        while (transform.position.y > moveToThisY)
        {
			Debug.Log(Time.deltaTime + " Track");
			transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
  
            if (transform.position.y <= -22.7f)
            {
               
               transform.position = new Vector3(0, 22.7f, 0);
                

            }

            yield return null;

        }

      
    }


	// Update is called once per frame
	void Update () {
		
	}
}
