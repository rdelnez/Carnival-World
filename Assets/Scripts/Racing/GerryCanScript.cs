using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerryCanScript : MonoBehaviour {

	public Object smokeBubble;
	public int value;
	public float speedY;
	public GameObject GM;
	public GMRacing GM_Script;
	public bool isCorrectAnswer;
	public SpriteRenderer firstNum;
	public SpriteRenderer secondNum;
	public GerryCanManager GerryCan_Script;
	public bool isGerryCanAvailable;
	public QMRacing QM_Script;
	public SoundManagerScript SM_Script;


	// Use this for initialization
	void Awake()
	{
		speedY = -6.0f;
		SM_Script = GameObject.FindWithTag("SoundManager").gameObject.GetComponent<SoundManagerScript>();
		GM_Script = GameObject.FindWithTag("GameManager").gameObject.GetComponent<GMRacing>();
		GerryCan_Script = GameObject.FindWithTag("GerryCanManager").gameObject.GetComponent<GerryCanManager>();
		QM_Script = GameObject.FindWithTag("QuestionManager").gameObject.GetComponent<QMRacing>();
		firstNum = transform.GetChild(0).GetComponent<SpriteRenderer>();
		secondNum = transform.GetChild(1).GetComponent<SpriteRenderer>();
	}

	void Start ()
	{
		StartCoroutine(TestRed());
	}
	

	IEnumerator TestRed()
	{
		while (true)
		{   //Debug.Log("dfadsfsd");
			//Debug.Log(Time.deltaTime + " Can");
			transform.Translate(0, speedY * Time.deltaTime, 0);
			yield return null;
		}
	}

	public void ChangeGerryCanValue(int tempValue)
	{

		value = tempValue;
		Debug.Log("this is a value "+value);
		
		if(value < 10)
		{
			firstNum.sprite = Resources.Load<Sprite>("2D/Shared/Transparent 1x1");
			secondNum.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ"+ value.ToString());
			secondNum.transform.localPosition = new Vector3(0f, 0f, -0.1f);
			secondNum.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
		}
		else
		{
			string valueString = value.ToString();
			firstNum.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + valueString[0]);
			secondNum.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + valueString[1]);
		}

	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Collision2D");
		if(collision.gameObject.tag == "Player")
		{
			SM_Script.Play_SFX("STEEL BARREL NO.1");
			if (GM_Script.isGerryCanAvailable == true)
			{
				
				Instantiate(smokeBubble, transform.localPosition, Quaternion.identity);
				GM_Script.isGerryCanAvailable = false;
				QM_Script.InvokeQuestion();
				Destroy(this.gameObject);



			}
		}	
		else if (collision.gameObject.tag == "DeadZone")
		{
			
			DestroyGerryCan();
		
		}
	}



	public void DestroyGerryCan()
	{
		
		Destroy(gameObject);
	}
}
