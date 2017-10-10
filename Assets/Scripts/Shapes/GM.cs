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
    public GameObject origin;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public Sprite blackHeartImage;
	public Button gameOverButton;
	public GameObject gameOver;
	public int livesLeft;
    public Text scoreText;
    public int currentScore;
    public int enemyNeeded;
    ArrayList cubeSpawn = new ArrayList();
    public bool hasCorrectAnswer;
    public int moveAmount;

    // Use this for initialization
    void Start() {

        enemyNeeded = 6;
        hasCorrectAnswer = false;
        moveAmount = 0;
        livesLeft = 3;
        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update() {

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
        void PopulateEnemy()
        {
            for (int x = 0; x < enemyNeeded; x++)
            {
                if (hasCorrectAnswer == false)
                {
                    {
                        if (Random.Range(0, 6) == 3 || x == enemyNeeded - 1)
                        {

                            spawnCorrectEnemy();

                        }
                        else
                        {

                            spawnEnemy();

                        }
                    }
                }
                else
                {
                    spawnEnemy();
                }

                moveAmount++;
            }
        moveAmount = 0;
        hasCorrectAnswer = false;

        }
    void spawnEnemy() {


        enemyClone = Instantiate(enemy, new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
        cubeSpawn.Add(enemyClone);

    }
    void spawnCorrectEnemy()
    {


        enemyClone = Instantiate(correctEnemy, new Vector3(origin.transform.position.x + moveAmount * 4, origin.transform.position.y, origin.transform.position.z), Quaternion.identity) as GameObject;
        cubeSpawn.Add(enemyClone);
        hasCorrectAnswer = true;

    }
    public void removeLife() {

        if (livesLeft == 3)
        {

            heart3.GetComponent<Image>().sprite = blackHeartImage;

        }
        else if (livesLeft == 2)
        {

            heart2.GetComponent<Image>().sprite = blackHeartImage;

        }
        else {

            heart1.GetComponent<Image>().sprite = blackHeartImage;
			
			gameOver.gameObject.SetActive(true);
			gameOverButton.gameObject.SetActive(true);

		}

        livesLeft--;


    }

    public void addScore(){

        currentScore++;
        scoreText.text = "" + currentScore;

    }
    public void resetButton() {

        StartCoroutine(LevelLoader());

    }
    IEnumerator LevelLoader()
    {
        yield return new WaitForSeconds(0.5f);
        AsyncOperation async = SceneManager.LoadSceneAsync("MainGame");
        yield return async;
    }
}
