using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GMRacing : MonoBehaviour
{
	public int lives;
	public int score;
	public int checkpoint;
	//public GameObject MonsterTruck;
	public bool isGerryCanAvailable;
	public bool isQuestionStarted;


	// public static GMRacing instance = null;

	void Awake()
	{
		// if (instance == null)
		// {
		//     instance = this;
		// }
		//  else if (instance != this)
		// {
		//      Destroy(gameObject);
		//  }
		//  Setup();  
		isGerryCanAvailable = true;
		isQuestionStarted = false;
		lives = 5;
		checkpoint = 100;
		score = 0;
	}

	public void Setup()
	{
		// Instantiate(GerryCan, transform.position, Quaternion.identity);
        
	}

	void Start()
	{
		// LeftNum1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
		// RightNum1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
		// Operator.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/" + (Operators)Random.Range(1, 5));
	}
}
