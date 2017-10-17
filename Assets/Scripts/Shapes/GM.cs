using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

	public GameObject character;
	public GameObject enemy;
	public GameObject enemyClone;
	public int enemyNumber;
	public GameObject correctEnemyClone;
	public GameObject correctEnemy;
	public string correctEnemyName;
	public GameObject origin;
	public GameObject shapeName;
	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;
	public GameObject questionShape;
	public Sprite blackHeartImage;
	public Button gameOverButton;
	public GameObject gameOver;
	public int livesLeft;
	public Text scoreText;
	public int currentScore;
	public int enemyNeeded;
	int correctShapeNumber;
	int difficulty;
	public List<GameObject> enemySpawn;
	public List<Object> enemyList;
	public List<string> ShapeList;
	public ArrayList enemyNameList;
	public bool hasCorrectAnswer;
	public int moveAmount;

	// Use this for initialization
	void Start()
	{

		enemySpawn = new List<GameObject>();
		enemyList = new List<Object>();
		enemyNeeded = 6;
		hasCorrectAnswer = false;
		moveAmount = 0;
		livesLeft = 3;

		CreateShapeList();
		StartCoroutine(StartGame());
		LoadQuestions();
		difficulty = 0;
	}


	IEnumerator StartGame()
	{
		while (livesLeft > 0)
		{
			SetQuestion();
			yield return new WaitForSeconds(1);
			PopulateEnemy();
			yield return new WaitForSeconds(4);

		}


	}
	void CreateShapeList()
	{
		//Easy
		ShapeList.Add("CorrectWinner"); // 0 for testing, leave blank, start from 1 in random range.

		ShapeList.Add("Black_Circle"); // 1
		ShapeList.Add("Black_Heart");
		ShapeList.Add("Black_Triangle");
		ShapeList.Add("Black_Square");
		ShapeList.Add("Black_Diamond");
		ShapeList.Add("Black_Star"); // 6

		ShapeList.Add("Blue_Circle"); // 7
		ShapeList.Add("Blue_Heart");
		ShapeList.Add("Blue_Triangle");
		ShapeList.Add("Blue_Square");
		ShapeList.Add("Blue_Diamond");
		ShapeList.Add("Blue_Star"); // 12

		ShapeList.Add("Brown_Circle"); // 13
		ShapeList.Add("Brown_Heart");
		ShapeList.Add("Brown_Triangle");
		ShapeList.Add("Brown_Square");
		ShapeList.Add("Brown_Diamond");
		ShapeList.Add("Brown_Star"); // 18

		ShapeList.Add("Cyan_Circle"); //19
		ShapeList.Add("Cyan_Heart");
		ShapeList.Add("Cyan_Triangle");
		ShapeList.Add("Cyan_Square");
		ShapeList.Add("Cyan_Diamond");
		ShapeList.Add("Cyan_Star"); //24

		ShapeList.Add("Green_Circle"); //25
		ShapeList.Add("Green_Heart");
		ShapeList.Add("Green_Triangle");
		ShapeList.Add("Green_Square");
		ShapeList.Add("Green_Diamond");
		ShapeList.Add("Green_Star"); //30

		ShapeList.Add("Grey_Circle"); //31
		ShapeList.Add("Grey_Heart");
		ShapeList.Add("Grey_Triangle");
		ShapeList.Add("Grey_Square");
		ShapeList.Add("Grey_Diamond");
		ShapeList.Add("Grey_Star"); //36

		ShapeList.Add("Orange_Circle"); //37
		ShapeList.Add("Orange_Heart");
		ShapeList.Add("Orange_Triangle");
		ShapeList.Add("Orange_Square");
		ShapeList.Add("Orange_Diamond");
		ShapeList.Add("Orange_Star"); //42

		ShapeList.Add("Pink_Circle"); //43
		ShapeList.Add("Pink_Heart");
		ShapeList.Add("Pink_Triangle");
		ShapeList.Add("Pink_Square");
		ShapeList.Add("Pink_Diamond");
		ShapeList.Add("Pink_Star"); //48

		ShapeList.Add("Purple_Circle"); //49
		ShapeList.Add("Purple_Heart");
		ShapeList.Add("Purple_Triangle");
		ShapeList.Add("Purple_Square");
		ShapeList.Add("Purple_Diamond");
		ShapeList.Add("Purple_Star"); //54

		ShapeList.Add("Red_Circle"); //55
		ShapeList.Add("Red_Heart");
		ShapeList.Add("Red_Triangle");
		ShapeList.Add("Red_Square");
		ShapeList.Add("Red_Diamond");
		ShapeList.Add("Red_Star"); //60

		ShapeList.Add("White_Circle"); //61
		ShapeList.Add("White_Heart");
		ShapeList.Add("White_Triangle");
		ShapeList.Add("White_Square");
		ShapeList.Add("White_Diamond");
		ShapeList.Add("White_Star"); //66

		ShapeList.Add("Yellow_Circle"); //67
		ShapeList.Add("Yellow_Heart");
		ShapeList.Add("Yellow_Triangle");
		ShapeList.Add("Yellow_Square");
		ShapeList.Add("Yellow_Diamond");
		ShapeList.Add("Yellow_Star"); //72

		if (difficulty >= 1)
		{ // Hard

			ShapeList.Add("Black_SemiCricle"); //73
			ShapeList.Add("Black_Oval");
			ShapeList.Add("Black_Crescent");
			ShapeList.Add("Black_Pentagon");
			ShapeList.Add("Black_Hexagon");
			ShapeList.Add("Black_Heptagon"); //78

			ShapeList.Add("Blue_SemiCricle"); //79
			ShapeList.Add("Blue_Oval");
			ShapeList.Add("Blue_Crescent");
			ShapeList.Add("Blue_Pentagon");
			ShapeList.Add("Blue_Hexagon");
			ShapeList.Add("Blue_Heptagon"); //84

			ShapeList.Add("Brown_SemiCricle"); //85
			ShapeList.Add("Brown_Oval");
			ShapeList.Add("Brown_Crescent");
			ShapeList.Add("Brown_Pentagon");
			ShapeList.Add("Brown_Hexagon");
			ShapeList.Add("Brown_Heptagon"); //90

			ShapeList.Add("Cyan_SemiCricle"); //91
			ShapeList.Add("Cyan_Oval");
			ShapeList.Add("Cyan_Crescent");
			ShapeList.Add("Cyan_Pentagon");
			ShapeList.Add("Cyan_Hexagon");
			ShapeList.Add("Cyan_Heptagon"); //96

			ShapeList.Add("Green_SemiCricle"); //97
			ShapeList.Add("Green_Oval");
			ShapeList.Add("Green_Crescent");
			ShapeList.Add("Green_Pentagon");
			ShapeList.Add("Green_Hexagon");
			ShapeList.Add("Green_Heptagon"); //102

			ShapeList.Add("Grey_SemiCricle"); //103
			ShapeList.Add("Grey_Oval");
			ShapeList.Add("Grey_Crescent");
			ShapeList.Add("Grey_Pentagon");
			ShapeList.Add("Grey_Hexagon");
			ShapeList.Add("Grey_Heptagon"); //108

			ShapeList.Add("Orange_SemiCricle"); //109
			ShapeList.Add("Orange_Oval");
			ShapeList.Add("Orange_Crescent");
			ShapeList.Add("Orange_Pentagon");
			ShapeList.Add("Orange_Hexagon");
			ShapeList.Add("Orange_Heptagon"); //114

			ShapeList.Add("Pink_SemiCricle"); //115
			ShapeList.Add("Pink_Oval");
			ShapeList.Add("Pink_Crescent");
			ShapeList.Add("Pink_Pentagon");
			ShapeList.Add("Pink_Hexagon");
			ShapeList.Add("Pink_Heptagon"); //120

			ShapeList.Add("Purple_SemiCricle"); //121
			ShapeList.Add("Purple_Oval");
			ShapeList.Add("Purple_Crescent");
			ShapeList.Add("Purple_Pentagon");
			ShapeList.Add("Purple_Hexagon");
			ShapeList.Add("Purple_Heptagon"); //126

			ShapeList.Add("Red_SemiCricle"); //127
			ShapeList.Add("Red_Oval");
			ShapeList.Add("Red_Crescent");
			ShapeList.Add("Red_Pentagon");
			ShapeList.Add("Red_Hexagon");
			ShapeList.Add("Red_Heptagon"); //132

			ShapeList.Add("White_SemiCricle"); //127
			ShapeList.Add("White_Oval");
			ShapeList.Add("White_Crescent");
			ShapeList.Add("White_Pentagon");
			ShapeList.Add("White_Hexagon");
			ShapeList.Add("White_Heptagon"); //138

			ShapeList.Add("Yellow_SemiCricle"); //139
			ShapeList.Add("Yellow_Oval");
			ShapeList.Add("Yellow_Crescent");
			ShapeList.Add("Yellow_Pentagon");
			ShapeList.Add("Yellow_Hexagon");
			ShapeList.Add("Yellow_Heptagon"); //144

		}

	}

	void SetQuestion()
	{

		correctShapeNumber = Random.Range(1, 5);
		shapeName.GetComponent<Image>().sprite = Resources.Load<Sprite>("2D/Shapes/Static/" + ShapeList[correctShapeNumber] + " 1");

	}

	void PopulateEnemy()
	{

		character.GetComponent<CharacterScript>().CollisionToggle();
		for (int x = 0; x < enemyNeeded; x++)
		{
			if (hasCorrectAnswer == false)
			{
				{
					if (Random.Range(0, 6) == 3 || x == enemyNeeded - 1)
					{

						SpawnCorrectEnemy(correctShapeNumber);

					}
					else
					{

						SpawnEnemy();

					}
				}
			}
			else
			{
				SpawnEnemy();
			}

			moveAmount++;
		}
		moveAmount = 0;
		hasCorrectAnswer = false;

	}
	void SpawnEnemy()
	{


		enemyClone = Instantiate(enemy, new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
		enemySpawn.Add(enemyClone);
		enemyNumber = Random.Range(0, 6);
		if (enemyNumber == correctShapeNumber)
		{
			enemyNumber--;
			enemyClone.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shapes/Static/" + ShapeList[enemyNumber]);
		}
		else
		{
			enemyClone.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shapes/Static/" + ShapeList[enemyNumber]);
		}
		enemyClone.transform.GetChild(0).transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

	}

	void SpawnCorrectEnemy(int correctShapeNumber)
	{

		correctEnemyClone = Instantiate(correctEnemy, new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
		enemySpawn.Add(correctEnemyClone);
		//correctEnemyClone.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load("2D/Shapes/Static/Yellow_Triangle") as Sprite;
		//correctEnemyClone.GetComponentInChildren<Image>().sprite = Resources.Load("2D/Shapes/Static/" + ShapeList[1]) as Sprite;

		correctEnemyClone.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shapes/Static/" + ShapeList[correctShapeNumber]);
		correctEnemyClone.transform.GetChild(0).transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
		hasCorrectAnswer = true;

	}
	public void RemoveLife()
	{

		livesLeft--;

		if (livesLeft == 2)
		{

			heart3.GetComponent<Image>().sprite = blackHeartImage;

		}
		else if (livesLeft == 1)
		{

			heart2.GetComponent<Image>().sprite = blackHeartImage;

		}
		else
		{

			heart1.GetComponent<Image>().sprite = blackHeartImage;

			gameOver.gameObject.SetActive(true);
			gameOverButton.gameObject.SetActive(true);

		}




	}

	public void AddScore()
	{

		currentScore++;
		scoreText.text = "" + currentScore;

	}
	public void ResetButton()
	{

		StartCoroutine(LevelLoader());

	}
	IEnumerator LevelLoader()
	{
		yield return new WaitForSeconds(0.5f);
		AsyncOperation async = SceneManager.LoadSceneAsync("PolygonParkScene");
		yield return async;
	}
	/*--public void EnemyDestroy(){

		//StartCoroutine(PlayerCollision());
		for (int i = 0; i < enemySpawn.Count; i++)
		{


			Destroy(enemySpawn[i]);
		
		}

	}--*/
	IEnumerator PlayerCollision()
	{

		for (int i = 0; i < enemySpawn.Count; i++)
		{


			Destroy(enemySpawn[i]);
			yield return null;


		}

	}
	public void LoadQuestions()
	{

		int x = Random.Range(0, 1);


	}
}
