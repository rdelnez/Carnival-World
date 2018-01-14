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


	// Use this for initialization
	void Awake()
	{
		speedY = -6.0f;
		GM_Script = GameObject.FindWithTag("GameManager").gameObject.GetComponent<GMRacing>();
		GerryCan_Script = GameObject.FindWithTag("GerryCanManager").gameObject.GetComponent<GerryCanManager>();
		firstNum = transform.GetChild(0).GetComponent<SpriteRenderer>();
		secondNum = transform.GetChild(1).GetComponent<SpriteRenderer>();
	}

	void Start ()
	{
		
		StartCoroutine(TestRed());
		
		
	}
	
	

	// Update is called once per frame
	void Update ()
	{

	}

	IEnumerator TestRed()
	{
		while (true)
		{   Debug.Log("dfadsfsd");
			//Debug.Log(Time.deltaTime + " Can");
			transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
			yield return null;
		}
	}

	public void ChangeGerryCanValue(int tempValue) {

		
		value = tempValue;
		Debug.Log("this is a value "+value);
		
		if(value < 10)
		{
			
			firstNum.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ0");
			secondNum.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ"+ value.ToString());

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

		if (GM_Script.isGerryCanAvailable == true)
		{
			Instantiate(smokeBubble, transform.localPosition, Quaternion.identity);
			Destroy(this.gameObject);
			GM_Script.isGerryCanAvailable = false;
		}

		if (collision.gameObject.tag == "DeadZone")
		{
			
			DestroyGerryCan();
		}
		
	}

	public void DestroyGerryCan() {

		Destroy(this.gameObject);
	}


}
