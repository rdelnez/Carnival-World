using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QMRacing : MonoBehaviour
{
	public Image num1Left2, num2Right, num1Left, num2Right2, Operator;
	public bool isGameRunning;
	public GMRacing GM_Script;
	public enum Operators
	{
		Plus = 1,
		Minus = 2,
		Multiply = 3,
		Divide = 4
	}
	Operators calcSymbol;

	private int num1, num2, maxValue, answer, value;
	string difficulty;
	void Start()
	{
		GM_Script = GameObject.FindWithTag("GameManager").gameObject.GetComponent<GMRacing>();
		isGameRunning = true;
		num1Left.GetComponent<Image>();
		num2Right.GetComponent<Image>();
		num1Left2.GetComponent<Image>();
		num2Right2.GetComponent<Image>();
		Operator.GetComponent<Image>();
		difficulty = "Normal" /*SVM_Script.Instance.gameDifficulty*/;
		StartCoroutine(StartGenQuestion());
	}

	public IEnumerator StartGenQuestion() {
		while(isGameRunning)
		{
			Debug.Log("entering GenQ");
			ResetVariablesNewQuestion();
			GenQuestion();
			yield return new WaitForSeconds(11.0f);
		}
	}

	public void ResetVariablesNewQuestion() {
		GM_Script.isGerryCanAvailable = true;
	}

	public GerryCanManager GCM;

	public void GenQuestion()
	{
		
		if (difficulty == "Normal")
		{
			calcSymbol = (Operators)Random.Range(1, 3);
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
		GCM.NewAnswer(answer);
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
				QuestionSpriteManager(value);
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Plus");
				break;
			}
			else if(calcSymbol == Operators.Minus)
			{
				num1 = Random.Range(5, maxValue);
				//num2 = Random.Range(3, maxValue);
				num2 = Random.Range(1, num2);

				answer = num1 - num2;
				QuestionSpriteManager(value);
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Minus");
				break;
			}
			else if(calcSymbol == Operators.Multiply)
			{
				num1 = Random.Range(3, 10);
				num2 = Random.Range(3, 11);

				answer = num1 * num2;
				QuestionSpriteManager(value);
				Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Multiply");
				break;
			}
			else
			{
				num1 = Random.Range(3, maxValue);
				num2 = Random.Range(3, maxValue);
				if(num1 % num2 == 0)
				{
					answer = num1 / num2;
					QuestionSpriteManager(value);
					Operator.sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/Divide");
					break;
				}
			}
			yield return null;
		}

		
	}

	IEnumerator DisplayQuestion()
	{
		while(true)
		{

			
			yield return null;
		}
		
	}
	public void QuestionSpriteManager(int TempValue){
	    value = TempValue;

		if(value < 10)
		{
			num2Right.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + num2);
			num1Left.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + num1);
		}
		else
		{
			string ValueString = value.ToString();
			num2Right.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[0]);
			num1Left.sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + ValueString[1]);
		}
		
	}
	}
