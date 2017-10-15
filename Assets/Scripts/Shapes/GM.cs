using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public GameObject character;
	public GameObject enemy;
	public GameObject enemyClone;
	public GameObject correctEnemy;
	public string correctEnemyName;
	public GameObject origin;
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
	void Start() {

		enemySpawn = new List<GameObject>();
		enemyList = new List<Object>();
		enemyNeeded = 6;
		hasCorrectAnswer = false;
		moveAmount = 0;
		livesLeft = 3;
		correctShapeNumber = 0;
		CreateShapeList();
		StartCoroutine(StartGame());
		LoadQuestions();
		difficulty = 0;
	}


	IEnumerator StartGame()
	{
		while (livesLeft > 0)
		{
			yield return new WaitForSeconds(1);
			PopulateEnemy();
			yield return new WaitForSeconds(4);

		}


	}
	void CreateShapeList() {
		//Easy
		ShapeList.Add("CorrectWinner"); // 0

		ShapeList.Add("BlackCircle"); // 1
		ShapeList.Add("BlackHeart");
		ShapeList.Add("BlackTriangle");
		ShapeList.Add("BlackSquare");
		ShapeList.Add("BlackDiamond");
		ShapeList.Add("BlackStar"); // 6

		ShapeList.Add("BlueCircle"); // 7
		ShapeList.Add("BlueHeart");
		ShapeList.Add("BlueTriangle");
		ShapeList.Add("BlueSquare");
		ShapeList.Add("BlueDiamond");
		ShapeList.Add("BlueStar"); // 12

		ShapeList.Add("BrownCircle"); // 13
		ShapeList.Add("BrownHeart");
		ShapeList.Add("BrownTriangle");
		ShapeList.Add("BrownSquare");
		ShapeList.Add("BrownDiamond");
		ShapeList.Add("BrownStar"); // 18

		ShapeList.Add("CyanCircle"); //19
		ShapeList.Add("CyanHeart");
		ShapeList.Add("CyanTriangle");
		ShapeList.Add("CyanSquare");
		ShapeList.Add("CyanDiamond");
		ShapeList.Add("CyanStar"); //24

		ShapeList.Add("GreenCircle"); //25
		ShapeList.Add("GreenHeart");
		ShapeList.Add("GreenTriangle");
		ShapeList.Add("GreenSquare");
		ShapeList.Add("GreenDiamond");
		ShapeList.Add("GreenStar"); //30

		ShapeList.Add("GreyCircle"); //31
		ShapeList.Add("GreyHeart");
		ShapeList.Add("GreyTriangle");
		ShapeList.Add("GreySquare");
		ShapeList.Add("GreyDiamond");
		ShapeList.Add("GreyStar"); //36

		ShapeList.Add("OrangeCircle"); //37
		ShapeList.Add("OrangeHeart");
		ShapeList.Add("OrangeTriangle");
		ShapeList.Add("OrangeSquare");
		ShapeList.Add("OrangeDiamond");
		ShapeList.Add("OrangeStar"); //42

		ShapeList.Add("PinkCircle"); //43
		ShapeList.Add("PinkHeart");
		ShapeList.Add("PinkTriangle");
		ShapeList.Add("PinkSquare");
		ShapeList.Add("PinkDiamond");
		ShapeList.Add("PinkStar"); //48

		ShapeList.Add("PurpleCircle"); //49
		ShapeList.Add("PurpleHeart");
		ShapeList.Add("PurpleTriangle");
		ShapeList.Add("PurpleSquare");
		ShapeList.Add("PurpleDiamond");
		ShapeList.Add("PurpleStar"); //54

		ShapeList.Add("RedCircle"); //55
		ShapeList.Add("RedHeart");
		ShapeList.Add("RedTriangle");
		ShapeList.Add("RedSquare");
		ShapeList.Add("RedDiamond");
		ShapeList.Add("RedStar"); //60

		ShapeList.Add("WhiteCircle"); //61
		ShapeList.Add("WhiteHeart");
		ShapeList.Add("WhiteTriangle");
		ShapeList.Add("WhiteSquare");
		ShapeList.Add("WhiteDiamond");
		ShapeList.Add("WhiteStar"); //66

		ShapeList.Add("YellowCircle"); //67
		ShapeList.Add("YellowHeart");
		ShapeList.Add("YellowTriangle");
		ShapeList.Add("YellowSquare");
		ShapeList.Add("YellowDiamond");
		ShapeList.Add("YellowStar"); //72

		if (difficulty >= 1) { // Hard

			ShapeList.Add("BlackSemiCricle"); //73
			ShapeList.Add("BlackOval");
			ShapeList.Add("BlackCrescent");
			ShapeList.Add("BlackPentagon");
			ShapeList.Add("BlackHexagon");
			ShapeList.Add("BlackHeptagon"); //78

			ShapeList.Add("BlueSemiCricle"); //79
			ShapeList.Add("BlueOval");
			ShapeList.Add("BlueCrescent");
			ShapeList.Add("BluePentagon");
			ShapeList.Add("BlueHexagon");
			ShapeList.Add("BlueHeptagon"); //84

			ShapeList.Add("BrownSemiCricle"); //85
			ShapeList.Add("BrownOval");
			ShapeList.Add("BrownCrescent");
			ShapeList.Add("BrownPentagon");
			ShapeList.Add("BrownHexagon");
			ShapeList.Add("BrownHeptagon"); //90

			ShapeList.Add("CyanSemiCricle"); //91
			ShapeList.Add("CyanOval");
			ShapeList.Add("CyanCrescent");
			ShapeList.Add("CyanPentagon");
			ShapeList.Add("CyanHexagon");
			ShapeList.Add("CyanHeptagon"); //96

			ShapeList.Add("GreenSemiCricle"); //97
			ShapeList.Add("GreenOval");
			ShapeList.Add("GreenCrescent");
			ShapeList.Add("GreenPentagon");
			ShapeList.Add("GreenHexagon");
			ShapeList.Add("GreenHeptagon"); //102

			ShapeList.Add("GreySemiCricle"); //103
			ShapeList.Add("GreyOval");
			ShapeList.Add("GreyCrescent");
			ShapeList.Add("GreyPentagon");
			ShapeList.Add("GreyHexagon");
			ShapeList.Add("GreyHeptagon"); //108

			ShapeList.Add("OrangeSemiCricle"); //109
			ShapeList.Add("OrangeOval");
			ShapeList.Add("OrangeCrescent");
			ShapeList.Add("OrangePentagon");
			ShapeList.Add("OrangeHexagon");
			ShapeList.Add("OrangeHeptagon"); //114

			ShapeList.Add("PinkSemiCricle"); //115
			ShapeList.Add("PinkOval");
			ShapeList.Add("PinkCrescent");
			ShapeList.Add("PinkPentagon");
			ShapeList.Add("PinkHexagon");
			ShapeList.Add("PinkHeptagon"); //120

			ShapeList.Add("PurpleSemiCricle"); //121
			ShapeList.Add("PurpleOval");
			ShapeList.Add("PurpleCrescent");
			ShapeList.Add("PurplePentagon");
			ShapeList.Add("PurpleHexagon");
			ShapeList.Add("PurpleHeptagon"); //126

			ShapeList.Add("RedSemiCricle"); //127
			ShapeList.Add("RedOval");
			ShapeList.Add("RedCrescent");
			ShapeList.Add("RedPentagon");
			ShapeList.Add("RedHexagon");
			ShapeList.Add("RedHeptagon"); //132

			ShapeList.Add("WhiteSemiCricle"); //127
			ShapeList.Add("WhiteOval");
			ShapeList.Add("WhiteCrescent");
			ShapeList.Add("WhitePentagon");
			ShapeList.Add("WhiteHexagon");
			ShapeList.Add("WhiteHeptagon"); //138

			ShapeList.Add("YellowSemiCricle"); //139
			ShapeList.Add("YellowOval");
			ShapeList.Add("YellowCrescent");
			ShapeList.Add("YellowPentagon");
			ShapeList.Add("YellowHexagon");
			ShapeList.Add("YellowHeptagon"); //144

		}

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
	void SpawnEnemy() {


		enemyClone = Instantiate(enemy, new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
		enemySpawn.Add(enemyClone);

	}

	void SpawnCorrectEnemy(int ShapeNumber)
	{

		enemyClone = Instantiate(Resources.Load("Prefabs/Shapes/2D prefabs/" + ShapeList[ShapeNumber]), new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
		enemySpawn.Add(enemyClone);
		hasCorrectAnswer = true;

	}
	public void RemoveLife() {

		livesLeft--;

		if (livesLeft == 2)
		{

			heart3.GetComponent<Image>().sprite = blackHeartImage;

		}
		else if (livesLeft == 1)
		{

			heart2.GetComponent<Image>().sprite = blackHeartImage;

		}
		else {

			heart1.GetComponent<Image>().sprite = blackHeartImage;

			gameOver.gameObject.SetActive(true);
			gameOverButton.gameObject.SetActive(true);

		}

		


	}

	public void AddScore() {

		currentScore++;
		scoreText.text = "" + currentScore;

	}
	public void ResetButton() {

		StartCoroutine(LevelLoader());

	}
	IEnumerator LevelLoader()
	{
		yield return new WaitForSeconds(0.5f);
		AsyncOperation async = SceneManager.LoadSceneAsync("MainGame");
		yield return async;
	}
	public void EnemyDestroy(){

		//StartCoroutine(PlayerCollision());
		for (int i = 0; i < enemySpawn.Count; i++)
		{


			Destroy(enemySpawn[i]);
		
		}

	}
	IEnumerator PlayerCollision() {

		for (int i = 0; i < enemySpawn.Count; i++ ){

			
			Destroy(enemySpawn[i]);
			yield return null;


		}

	}
	public void LoadQuestions() {

		int x = Random.Range(0, 1);

	
	}
}
