using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QMRacing : MonoBehaviour
{

	public enum Operators
	{
		Plus = 1,
		Minus = 2,
		Multiply = 3,
		Divide = 4
	}
	Operators calcSymbol;

	private int num1, num2, maxValue, answer;
	string difficulty;
	void Start()
	{
		difficulty = "Normal" /*SVM_Script.Instance.gameDifficulty*/;
		GenQuestion();
	}

	public GameObject num1Left, num1Right, num2Left, num2Right, Operator;

	public GerryCanManager GCM;

	public void GenQuestion()
	{
		if(difficulty == "Normal")
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
		//GCM.NewAnswer(answer);
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
				break;
			}
			else if(calcSymbol == Operators.Minus)
			{
				num1 = Random.Range(3, maxValue);
				num2 = Random.Range(3, num1 + 1);

				answer = num1 - num2;
				break;
			}
			else if(calcSymbol == Operators.Multiply)
			{
				num1 = Random.Range(3, 10);
				num2 = Random.Range(3, 11);

				answer = num1 * num2;
				break;
			}
			else
			{
				num1 = Random.Range(3, maxValue);
				num2 = Random.Range(3, num1 + 1);
				if(num1 % num2 == 0)
				{
					answer = num1 / num2;
					break;
				}
			}
			yield return null;
		}

		DisplayQuestion();
	}

	IEnumerator DisplayQuestion()
	{
		while(true)
		{

			//Make things happen Kevin
			yield return null;
		}
		
	}
}
