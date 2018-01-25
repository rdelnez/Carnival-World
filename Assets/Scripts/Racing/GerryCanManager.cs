using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerryCanManager : MonoBehaviour
{

	List<Vector3> spawnPoints;
	List<int> spawnIndecies;

	public Object gerryCanPrefab;
	public GameObject gerryCanGameObject;
	public SoundManagerScript SM_Script;
	public string difficulty;
	public int currentAnswer, rand1, rand2;
	// Use this for initialization
	void Awake()
	{
		SM_Script = GameObject.FindWithTag("SoundManager").gameObject.GetComponent<SoundManagerScript>();
		spawnPoints = new List<Vector3>();
		spawnIndecies = new List<int>();
		for(int x = 0; x < transform.childCount; x++)
		{
			spawnPoints.Add(transform.GetChild(x).position);
			spawnIndecies.Add(x);
		}
		difficulty = "Normal";
	}

	public void InstantiateGerryCan()
	{

		if(difficulty == "Normal")
		{
			int x = Random.Range(0, spawnIndecies.Count);
			gerryCanGameObject = Instantiate(gerryCanPrefab, spawnPoints[spawnIndecies[x]], Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, rand1, false);
			spawnIndecies.RemoveAt(x);

			x = Random.Range(0, spawnIndecies.Count);
			gerryCanGameObject = Instantiate(gerryCanPrefab, spawnPoints[spawnIndecies[x]], Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, rand2, false);
			spawnIndecies.RemoveAt(x);

			x = Random.Range(0, spawnIndecies.Count);
			gerryCanGameObject = Instantiate(gerryCanPrefab, spawnPoints[spawnIndecies[x]], Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, currentAnswer, true);
			spawnIndecies.RemoveAt(x);


		}
		for(int x = 0; x < spawnPoints.Count; x++)
		{
			spawnIndecies.Add(x);
		}
	}

	public void NewAnswer(int newAnswer)
	{
		rand1 = Random.Range(1, newAnswer);
		rand2 = Random.Range(1, newAnswer);

		currentAnswer = newAnswer;
		StartCoroutine(RandFix());
	}

	IEnumerator RandFix()
	{
		while(rand1 == rand2)
		{
			rand2 = Random.Range(1, 9);
			yield return null;
		}
		InstantiateGerryCan();
	}

	void DisplayNumberOnCan(GameObject tempGerryCan, int tempValue, bool isCorrect)
	{
		GerryCanScript tempScript;
		tempScript = tempGerryCan.GetComponent<GerryCanScript>();
		tempScript.ChangeGerryCanValue(tempValue);
		if (isCorrect)
		{
			
			tempScript.isCorrectAnswer = true;
		}
	}


}
