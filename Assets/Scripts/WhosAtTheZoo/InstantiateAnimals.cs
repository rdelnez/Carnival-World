using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateAnimals : MonoBehaviour {
    //public GameObject AnimalPrefab;
    //GameObject AnimalPrefabClone;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    public GameObject Prefab6;
    public GameObject Prefab7;
    public GameObject Prefab8;
    public GameObject Prefab9;
    public GameObject Prefab10;
    public GameObject Prefab11;
    public GameObject Prefab12;
    public GameObject Prefab13;
    public GameObject Prefab14;
    public GameObject Prefab15;
    public GameObject Prefab16;
    public GameObject Prefab17;
    public GameObject Prefab18;
    public GameObject Prefab19;
    public GameObject Prefab20;
    public GameObject Prefab21;
    public GameObject Prefab22;
    public GameObject Prefab23;
    public GameObject Prefab24;



    // Use this for initialization
    void Start() {
        // AnimalPrefabClone = Instantiate(AnimalPrefab, transform.position, Quaternion.identity) as GameObject;
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



        int prefabIndex = UnityEngine.Random.Range(0, 24);
        Instantiate(prefabList[prefabIndex]);

        if (prefabIndex == 0)
        {
           

        }
        else if (prefabIndex == 1)
        {


        }
        else if (prefabIndex == 2)
        {


        }
        else if (prefabIndex == 3)
        {


        }
        else if (prefabIndex == 4)
        {


        }
        else if (prefabIndex == 5)
        {


        }
        else if (prefabIndex == 6)
        {


        }
        else if (prefabIndex == 7)
        {


        }
        else if (prefabIndex == 8)
        {


        }
        else if (prefabIndex == 9)
        {


        }
        else if (prefabIndex == 10)
        {


        }
        else if (prefabIndex == 11)
        {


        }
        else if (prefabIndex == 12)
        {


        }
        else if (prefabIndex == 13)
        {


        }
        else if (prefabIndex == 14)
        {


        }
        else if (prefabIndex == 15)
        {


        }
        else if (prefabIndex == 16)
        {


        }
        else if (prefabIndex == 17)
        {


        }
        else if (prefabIndex == 18)
        {


        }
        else if (prefabIndex == 19)
        {


        }
        else if (prefabIndex == 20)
        {


        }
        else if (prefabIndex == 21)
        {


        }
        else if (prefabIndex == 22)
        {


        }
        else if (prefabIndex == 23)
        {


        }
        else if (prefabIndex == 24)
        {


        }
    }
}

	

	// Update is called once per frame
	void Update () {
		
	}
}
