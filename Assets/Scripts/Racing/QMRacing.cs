using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QMRacing : MonoBehaviour
{
	public Image num1Left, num1Right, num2Left, num2Right, Operator;
	public bool isGameRunning;
	[SerializeField]
	private GMRacing GM_Script;
	public GerryCanManager GCM;
	public enum Operators
	{
		Plus = 1,
		Minus = 2,
		Multiply = 3,
		Divide = 4
	}
	Operators calcSymbol;
	
	private int num1, num2, maxValue, answer;
	private string difficulty;
	void Start()
	{
		GM_Script = GameObject.FindWithTag("GameManager").gameObject.GetComponent<GMRacing>();
		isGameRunning = true;
		num1Left.GetComponent<Image>();
		num1Right.GetComponent<Image>();
		num2Left.GetComponent<Image>();
		num2Right.GetComponent<Image>();
		Operator.GetComponent<Image>();
		difficulty = "Normal" /*SVM_Script.Instance.gameDifficulty*/;
		StartCoroutine(StartGenQuestion());
	}

	public IEnumerator StartGenQuestion()
	{
		while(isGameRunning)
		{
			Debug.Log("entering GenQ");
			ResetVariablesNewQuestion();
			GenQuestion();
			yield return new WaitForSeconds(10.5f);
		}
	}

	public void ResetVariablesNewQuestion()
	{
		GM_Script.isGerryCanAvailable = true;
	}


	public void GenQuestion()
	{

		if(difficulty == "Normal")
		{
			calcSymbol = Operators.Divide/*(Operators)Random.Range(1, 3)*/;
			maxValue = 10;
		}
		else if(difficulty == "Hard")
		{
			calcSymbol = (Operators)Random.Range(1, 4);
			maxValue = 25;
		}
		else
		{
			calcSymbol = (Operators)Random.Range(1, 5);
			maxValue = 50;
		}

		StartCoroutine(QuestionGen());
	}

	IEnumerator QuestionGen()
	{
		while(true)
		{
			if(calcSymbol == Operators.Plus)
			{
				num1 = Random.Range(3, maxValue);
				num2 = Random.Range(3, maxValue);

				answer = num1 + num2;
				QuestionSpriteManager();
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Plus");
				GCM.NewAnswer(answer);
				break;
			}
			else if(calcSymbol == Operators.Minus)
			{
				num1 = Random.Range(5, maxValue);
				//num2 = Random.Range(3, maxValue);
				num2 = Random.Range(1, num2);

				answer = num1 - num2;
				QuestionSpriteManager();
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Minus");
				GCM.NewAnswer(answer);
				break;
			}
			else if(calcSymbol == Operators.Multiply)
			{
				num1 = Random.Range(3, 10);
				num2 = Random.Range(3, 11);

				answer = num1 * num2;
				QuestionSpriteManager();
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Multiply");
				GCM.NewAnswer(answer);
				break;
			}
			else
			{
				Debug.Log("Try");
				num1 = Random.Range(5, maxValue);
				num2 = Random.Range(2, num1);
				if(num1 % num2 == 0)
				{
					Debug.Log("Succeed");
					answer = num1 / num2;
					QuestionSpriteManager();
					Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Divide");
					GCM.NewAnswer(answer);
					break;
				}
				Debug.Log("Try Harder");
				yield return null;
			}
		}

	}

	public void QuestionSpriteManager()
	{
		string ValueString;
		if(num1< 10)
		{
			num1Left.sprite = Resources.Load<Sprite>("2D/Shared/Transparent 1x1");
			num1Right.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + num1);
		}
		else
		{
			ValueString = num1.ToString();
			num1Left.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[0]);
			num1Right.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[1]);
		}
		if(num2 < 10)
		{
			num2Right.sprite = Resources.Load<Sprite>("2D/Shared/Transparent 1x1");
			num2Left.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + num2);
		}
		else
		{
			ValueString = num2.ToString();
			num2Left.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[0]);
			num2Right.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[1]);
		}
	}
}
