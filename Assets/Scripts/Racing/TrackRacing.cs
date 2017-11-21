using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRacing : MonoBehaviour {

    public GameObject RacingTrackOne;
    public GameObject RacingTrackTwo;
    public int moveToThisY;
    public float speedY;
   

	// Use this for initialization
	void Start () {
        speedY = -3.0f;
        moveToThisY = -100;
        

        StartCoroutine("MoveRaceTrack");
	}

    IEnumerator MoveRaceTrack()

    {
        while (transform.position.y > moveToThisY)
 
        {

            RacingTrackOne.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
            RacingTrackTwo.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);

            if (RacingTrackOne.transform.position.y <= -22.7f)

            {
               
                RacingTrackOne.transform.position = new Vector3(0, 22.7f, 0);
                
                yield return null;

            }



            if (RacingTrackTwo.transform.position.y <= -22.7f)


            {
                
                RacingTrackTwo.transform.position = new Vector3(0, 22.7f, 0);
                
                yield return null;
            }

            yield return null;

        }

      
    }


	// Update is called once per frame
	void Update () {
		
	}
}
