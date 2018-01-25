using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GMRacing : MonoBehaviour
{
	public int lives;
	public int score;
	public int checkpoint;
	public bool isGerryCanAvailable;
	public bool isQuestionStarted;
	public QMRacing QM_Script;
	public SoundManagerScript SM_Script;
	public GerryCanManager GerryCan_Script;
	public GameObject loadingScreen;
	public GameObject loadingAnimation;

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

		QM_Script = GameObject.FindWithTag("QuestionManager").gameObject.GetComponent<QMRacing>();
		SM_Script = GameObject.FindWithTag("SoundManager").gameObject.GetComponent<SoundManagerScript>();
		GerryCan_Script = GameObject.FindWithTag("GerryCanManager").gameObject.GetComponent<GerryCanManager>();
		loadingScreen.SetActive(false);
		loadingAnimation.SetActive(false);
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
		//SM_Script.Play_SFX("coin");
		// LeftNum1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
		// RightNum1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
		// Operator.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/" + (Operators)Random.Range(1, 5));
	}
}
