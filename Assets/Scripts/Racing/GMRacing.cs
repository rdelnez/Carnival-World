using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMRacing : MonoBehaviour {
    public int lives;
    public int score;
    public int checkpoint;
    public GameObject MonsterTruck;
    public GameObject GerryCan;
    public GameObject GerryCan2;
    public GameObject GerryCan3;
   // public static GMRacing instance = null;
    //public Sprite LeftNum;
    //public Sprite RightNum;
   // public GameObject LeftNum;
   // public GameObject RightNum;
    public GameObject Operator;

    public float speedY;
    public int MoveToY;
    public Text Equation;
    public int num1;
    public int num2;
    public Text RightAnswer;
    public Text WrongAnswer;
    enum Operators
    {
        Plus = 1,
        Minus = 2,
        Divide = 3,
        Multiply = 4
    }
    Operators calcSymbol;

    void Awake()
    {
       // if (instance == null)
       // {
       //     instance = this;
       // }
      //  else if (instance != this)
       // {
      //      Destroy(gameObject);
      //  }
      //  Setup();  
    }

    public void Setup()
    {
        // Instantiate(GerryCan, transform.position, Quaternion.identity);
        
    }

    void Start() {
        calcSymbol = (Operators)Random.Range(1, 5);
        lives = 5;
        checkpoint = 100;
        score = 0;
        speedY = -1.5f;
        MoveToY = -100;
        StartCoroutine("MoveGameObjects");
        num1 = (Random.Range(1, 10));
        num2 = (Random.Range(1, 10));
        Equation = Equation.GetComponent<Text>();
        Equation.text = (num1 * num2).ToString();
       // LeftNum.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
       // RightNum.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/NumberSprites/russ" + Random.Range(0, 10));
       // Operator.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D/Shared/OperatorSprites/" + (Operators)Random.Range(1, 5));
    }
  
    IEnumerator MoveGameObjects()

    {
        while (transform.position.y > MoveToY)

        {

            GerryCan.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
            GerryCan2.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
            GerryCan3.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);


            if (GerryCan.transform.position.y <= 2.6f && GerryCan2.transform.position.y <= 2.6f && GerryCan3.transform.position.y <= 2.6f)

            {
                
                GerryCan.transform.position = new Vector3(-3, 50f, -4);
                GerryCan2.transform.position = new Vector3(0, 50f, -4);
                GerryCan3.transform.position = new Vector3(3, 50f, -4);
                GerryCan.gameObject.SetActive(true);
                GerryCan2.gameObject.SetActive(true);
                GerryCan3.gameObject.SetActive(true);

                yield return null;

            }
           else if (GerryCan.transform.position.y <= 2.6f && GerryCan2.transform.position.y <= 2.6f && GerryCan3.transform.position.y <= 2.6f)
            {

                GerryCan.gameObject.SetActive(false);
                GerryCan2.gameObject.SetActive(false);
                GerryCan3.gameObject.SetActive(false);
                checkpoint = checkpoint - 20;
                score = score - 20;
                lives = lives - 1;

            }
            else if (GerryCan.transform.position.y <= 2.6f && GerryCan2.transform.position.y <= 2.6f && GerryCan3.transform.position.y <= 2.6f)
            {

                GerryCan.gameObject.SetActive(false);
                GerryCan2.gameObject.SetActive(false);
                GerryCan3.gameObject.SetActive(false);
                checkpoint = checkpoint + 20;
                score = score + 20;
            }

            yield return null;

        }


        
    }
}
