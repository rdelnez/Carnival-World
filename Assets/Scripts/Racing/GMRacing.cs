using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMRacing : MonoBehaviour {
    public int lives;
    public int score;
    public int checkpoint;
    public GameObject MonsterTruck;
    public GameObject GerryCan;
    public float speedY;
    public int MoveToY;


    // Use this for initialization
    void Start() {
        lives = 5;
        checkpoint = 100;
        score = 0;
        speedY = -0.5f;
        MoveToY = -100;
        StartCoroutine("MoveGameObjects");

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            checkpoint = checkpoint - 20;
           score = score - 20;
            lives = lives - 1;

        }
       else if (other.gameObject.CompareTag("Pick Up Correct"))
        {
           other.gameObject.SetActive(false);
           checkpoint = checkpoint + 20;
            score = score + 20;
        }
  }
    IEnumerator MoveGameObjects()

    {
        while (transform.position.y > MoveToY)

        {

            GerryCan.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
            GerryCan.transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);

            if (GerryCan.transform.position.y <= -22.8f)

            {

                GerryCan.transform.position = new Vector3(0, 22.8f, 0);
                this.gameObject.SetActive(true);
                yield return null;

            }



            if (GerryCan.transform.position.y <= -22.8f)


            {

                GerryCan.transform.position = new Vector3(0, 22.8f, 0);
                this.gameObject.SetActive(true);
                yield return null;
            }

            yield return null;

        }


        
    }
}
