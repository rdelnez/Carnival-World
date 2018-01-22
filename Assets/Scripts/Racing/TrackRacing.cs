using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRacing : MonoBehaviour {

    public int moveToThisY;
    public float speedY;
	public SpriteRenderer RacingTrackOne, RacingTrackTwo, RacingTrackThree;
	public int StageSelector;
	public QMRacing QM_Script;
	public SoundManagerScript SM_Script;

	private void Awake()
	{
		StageSelector = 0;
		RacingTrackOne.GetComponent<SpriteRenderer>();
		RacingTrackTwo.GetComponent<SpriteRenderer>();
		RacingTrackThree.GetComponent<SpriteRenderer>();
		QM_Script = GameObject.FindWithTag("QuestionManager").gameObject.GetComponent<QMRacing>();
		SM_Script = GameObject.FindWithTag("SoundManager").gameObject.GetComponent<SoundManagerScript>();
	}
	// Use this for initialization
	void Start ()
	{
		
		if (QM_Script.difficulty == "Normal")
		{
			StageSelector = 1;
			//Choose BG music
		}
		if (QM_Script.difficulty == "Hard")
		{
			StageSelector = 2;
		}
		if (QM_Script.difficulty == "Expert")
		{
			StageSelector = 3;
		}

		RacingTrackOne.sprite = Resources.Load<Sprite>("2D/Racing/Animation/Race Tracks/Racing-game-stage-" + StageSelector);
		RacingTrackTwo.sprite = Resources.Load<Sprite>("2D/Racing/Animation/Race Tracks/Racing-game-stage-" + StageSelector);
		RacingTrackThree.sprite = Resources.Load<Sprite>("2D/Racing/Animation/Race Tracks/Racing-game-stage-" + StageSelector);
		speedY = -6.0f;
        moveToThisY = -100;
        StartCoroutine("MoveRaceTrack");
	}

    IEnumerator MoveRaceTrack()

    {
        while (transform.position.y > moveToThisY)
        {
			//Debug.Log(Time.deltaTime + " Track");
			transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
  
            if (transform.position.y <= -22.7f)
            {
               
               transform.position = new Vector3(0, 40f, 0);
                

            }

            yield return null;

        }

      
    }


	// Update is called once per frame
	void Update () {
		
	}
}
