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


    // Use this for initialization
    void Start () {
        // AnimalPrefabClone = Instantiate(AnimalPrefab, transform.position, Quaternion.identity) as GameObject;
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);
        prefabList.Add(Prefab6);

        int prefabIndex = UnityEngine.Random.Range(0, 6);
        Instantiate(prefabList[prefabIndex]);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
