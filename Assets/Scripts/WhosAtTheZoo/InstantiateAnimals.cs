using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstantiateAnimals : MonoBehaviour {
    //public GameObject AnimalPrefab;
    //GameObject AnimalPrefabClone;
    public List<Object> prefabList = new List<Object>();
	public Object Prefab1;
    public Object Prefab2;
    public Object Prefab3;
    public Object Prefab4;
    public Object Prefab5;
    public Object Prefab6;
    public Object Prefab7;
    public Object Prefab8;
    public Object Prefab9;
    public Object Prefab10;
    public Object Prefab11;
    public Object Prefab12;
    public Object Prefab13;
    public Object Prefab14;
    public Object Prefab15;
    public Object Prefab16;
    public Object Prefab17;
    public Object Prefab18;
    public Object Prefab19;
    public Object Prefab20;
    public Object Prefab21;
    public Object Prefab22;
    public Object Prefab23;
    public Object Prefab24;

	public List<GameObject> buttonList;
	

	public List<string> tempAnimalNameList = new List<string>();
	public List<string> tempAnimalCorrectAnswerList = new List<string>();
	public string correctAnswer;
	public string secondAnswer;
	public bool buttonTextDone;
	public string buttonPressed;
	public bool isGameSetUp;

	public Text RightAnswer;
    public Text WrongAnswer;
    public Text WrongAnswer2;
    public GameObject CurrentAnimal;
    public GameObject GAMEOVER;
    public int totalScore;
    public int lives;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public Vector3 Pos1 = new Vector3(-170, -105, 0);
    public Vector3 Pos2 = new Vector3(170, -105, 0);
    public Vector3 Pos3 = new Vector3(0, -105, 0);



    private void Awake()
    {
        Pos1 = new Vector3(-170, -105, 0);
        Pos2 = new Vector3(170, -105, 0);
        Pos3 = new Vector3(0, -105, 0);
		buttonTextDone = false;
		buttonPressed = "none";
		isGameSetUp = false;
	}
    
    void Start() {
       
        lives = 5;
        totalScore = 0;

        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);
        prefabList.Add(Prefab6);
        prefabList.Add(Prefab7);
        prefabList.Add(Prefab8);
        prefabList.Add(Prefab9);
        prefabList.Add(Prefab10);
        prefabList.Add(Prefab11);
        prefabList.Add(Prefab12);
        prefabList.Add(Prefab13);
        prefabList.Add(Prefab14);
        prefabList.Add(Prefab15);
        prefabList.Add(Prefab16);
        prefabList.Add(Prefab17);
        prefabList.Add(Prefab18);
        prefabList.Add(Prefab19);
        prefabList.Add(Prefab20);
        prefabList.Add(Prefab21);
        prefabList.Add(Prefab22);
        prefabList.Add(Prefab23);
        prefabList.Add(Prefab24);

		tempAnimalCorrectAnswerList.Add("Lion");
		tempAnimalCorrectAnswerList.Add("Beaver");
		tempAnimalCorrectAnswerList.Add("Beetle");
		tempAnimalCorrectAnswerList.Add("Bird");
		tempAnimalCorrectAnswerList.Add("Black Bear");
		tempAnimalCorrectAnswerList.Add("Brown Bear");
		tempAnimalCorrectAnswerList.Add("Buffalo");
		tempAnimalCorrectAnswerList.Add("Bumble Bee");
		tempAnimalCorrectAnswerList.Add("Butterfly");
		tempAnimalCorrectAnswerList.Add("Chicken");
		tempAnimalCorrectAnswerList.Add("Cow");
		tempAnimalCorrectAnswerList.Add("Cayote");
		tempAnimalCorrectAnswerList.Add("Crab");
		tempAnimalCorrectAnswerList.Add("Dalmatian");
		tempAnimalCorrectAnswerList.Add("Donkey");
		tempAnimalCorrectAnswerList.Add("Dragonfly");
		tempAnimalCorrectAnswerList.Add("Duck");
		tempAnimalCorrectAnswerList.Add("Dugong");
		tempAnimalCorrectAnswerList.Add("Elephant");
		tempAnimalCorrectAnswerList.Add("Giraffe");
		tempAnimalCorrectAnswerList.Add("Hamster");
		tempAnimalCorrectAnswerList.Add("Hedgehog");
		tempAnimalCorrectAnswerList.Add("Horse");
		tempAnimalCorrectAnswerList.Add("Lady Bug");

		tempAnimalNameList.Add("Lion");
		tempAnimalNameList.Add("Cat");
		tempAnimalNameList.Add("Bird");
		tempAnimalNameList.Add("Beaver");
		tempAnimalNameList.Add("Beetle");
		tempAnimalNameList.Add("Bird");
		tempAnimalNameList.Add("Black Bear");
		tempAnimalNameList.Add("Brown Bear");
		tempAnimalNameList.Add("Buffalo");
		tempAnimalNameList.Add("Bumble Bee");
		tempAnimalNameList.Add("Butterfly");
		tempAnimalNameList.Add("Chicken");
		tempAnimalNameList.Add("Cow");
		tempAnimalNameList.Add("Cayote");
		tempAnimalNameList.Add("Crab");
		tempAnimalNameList.Add("Dalmatian");
		tempAnimalNameList.Add("Donkey");
		tempAnimalNameList.Add("Dragonfly");
		tempAnimalNameList.Add("Duck");
		tempAnimalNameList.Add("Dugong");

		buttonList = new List<GameObject>();
		ResetButtonList();
		

		animalAnswer("");
		
	}

	public void ButtonChange(GameObject but1, GameObject but2, GameObject but3) {
		int PosIndex = UnityEngine.Random.Range(0, 4);
		but1.transform.localPosition = new Vector3(-170, -105, 0);
		but2.transform.localPosition = new Vector3(170, -105, 0);
		but3.transform.localPosition = new Vector3(0, -105, 0);
	}

	public void ResetButtonList() {
		buttonList.Clear();
		buttonList.Add(Button1);
		buttonList.Add(Button2);
		buttonList.Add(Button3);
		
	}

	public void ChangeButtonText() {

		int PosIndex;
		int prefabIndex;
		buttonTextDone = false;

		while (!buttonTextDone)
		{
			
			PosIndex = Random.Range(0, buttonList.Count);
			Debug.Log(tempAnimalNameList[PosIndex] != correctAnswer && tempAnimalNameList[PosIndex] != secondAnswer);
			prefabIndex = Random.Range(0, tempAnimalNameList.Count);

			if (tempAnimalNameList[prefabIndex] != correctAnswer && tempAnimalNameList[prefabIndex] != secondAnswer)
			{
				Debug.Log(tempAnimalNameList[PosIndex]);
				Debug.Log("Entered if");
				buttonList[PosIndex].GetComponentInChildren<Text>().text = tempAnimalNameList[prefabIndex];
				secondAnswer = tempAnimalNameList[prefabIndex];
				buttonList.RemoveAt(PosIndex);
				buttonTextDone = true;
			}
		}
		
	}

	public void animalAnswer(string test)
	{

		if (buttonPressed == test && isGameSetUp)
		{
			//Start Put adding score here
			Debug.Log("Correct Answer");

		}
		else if(isGameSetUp)
		{
			//Start Put reducing score here
			Debug.Log("Wrong Answer");
		}

		isGameSetUp = true;

		ResetButtonList();

		Destroy(CurrentAnimal);
		int prefabIndex = UnityEngine.Random.Range(0, prefabList.Count);
		CurrentAnimal = Instantiate(prefabList[prefabIndex]) as GameObject;
		int PosIndex = UnityEngine.Random.Range(0, 4);
		
		PosIndex = Random.Range(0, buttonList.Count);
		buttonList[PosIndex].GetComponentInChildren<Text>().text = tempAnimalCorrectAnswerList[prefabIndex];
		if (PosIndex == 0) {
			buttonPressed = "Button1";
		}
		else if (PosIndex == 1)
		{
			buttonPressed = "Button2";
		}
		else if (PosIndex == 2)
		{
			buttonPressed = "Button3";
		}
		correctAnswer = tempAnimalCorrectAnswerList[prefabIndex];
		buttonList.RemoveAt(PosIndex);

		prefabList.RemoveAt(prefabIndex);
		tempAnimalCorrectAnswerList.RemoveAt(prefabIndex);

		//Start Animal Display


		ChangeButtonText();
		ChangeButtonText();






		//END Animal Display


	}

	public void CheckAnswer(string test) {
		if (buttonPressed == test)
		{
			Debug.Log("Correct Answer");
		}
		else {
			Debug.Log("Wrong Answer");
		}
	}
	 
    void Update () {
        if (lives <= 0)
        {
            Destroy(CurrentAnimal);
            GAMEOVER.SetActive(true);
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
			
        }
	}
}
