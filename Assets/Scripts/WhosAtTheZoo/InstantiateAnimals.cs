using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstantiateAnimals : MonoBehaviour {
    //public GameObject AnimalPrefab;
    //GameObject AnimalPrefabClone;
    List<Object> prefabList = new List<Object>();

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
    public Text RightAnswer;
    public Text WrongAnswer;
    public Text WrongAnswer2;
    public GameObject CurrentAnimal;
    



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
        CurrentAnimal = Instantiate(prefabList[prefabIndex]) as GameObject;

        if (prefabIndex == 0)
        {
            
            RightAnswer.text = "Lion";
            WrongAnswer.text = "Bat";
            WrongAnswer2.text = "Dog";


        }
        else if (prefabIndex == 1)
        {
            
            RightAnswer.text = "Beaver";
            WrongAnswer.text = "Otter";
            WrongAnswer2.text = "Lynx";
        }
        else if (prefabIndex == 2)
        {
            
            RightAnswer.text = "Beetle";
            WrongAnswer.text = "Fly";
            WrongAnswer2.text = "Wasp";
        }
        else if (prefabIndex == 3)
        {
            
            RightAnswer.text = "Bird";
            WrongAnswer.text = "Dinosaur";
            WrongAnswer2.text = "Emu";
        }
        else if (prefabIndex == 4)
        {
            
            RightAnswer.text = "Black Bear";
            WrongAnswer.text = "Brown Bear";
            WrongAnswer2.text = "Polar Bear";
        }
        else if (prefabIndex == 5)
        {
            
            RightAnswer.text = "Brown Bear";
            WrongAnswer.text = "Rat";
            WrongAnswer2.text = "Snake";
        }
        else if (prefabIndex == 6)
        {
            
            RightAnswer.text = "Buffalo";
            WrongAnswer.text = "Aligator";
            WrongAnswer2.text = "Zebra";
        }
        else if (prefabIndex == 7)
        {
            
            RightAnswer.text = "BumbleBee";
            WrongAnswer.text = "Wasp";
            WrongAnswer2.text = "Dragonfly";
        }
        else if (prefabIndex == 8)
        {
            
            RightAnswer.text = "Butterfly";
            WrongAnswer.text = "Dragon";
            WrongAnswer2.text = "Lion";
        }
        else if (prefabIndex == 9)
        {
            
            RightAnswer.text = "Chicken";
            WrongAnswer.text = "Bird";
            WrongAnswer2.text = "Cow";
        }
        else if (prefabIndex == 10)
        {
            
            RightAnswer.text = "Cow";
            WrongAnswer.text = "Duck";
            WrongAnswer2.text = "Horse";
        }
        else if (prefabIndex == 11)
        {
            
            RightAnswer.text = "Coyote";
            WrongAnswer.text = "Buffalo";
            WrongAnswer2.text = "Dalmation";
        }
        else if (prefabIndex == 12)
        {
            
            RightAnswer.text = "Crab";
            WrongAnswer.text = "Cow";
            WrongAnswer2.text = "Ladybug";
        }
        else if (prefabIndex == 13)
        {
            
            RightAnswer.text = "Dalmation";
            WrongAnswer.text = "Coyote";
            WrongAnswer2.text = "Brown Bear";
        }
        else if (prefabIndex == 14)
        {
            
            RightAnswer.text = "Donkey";
            WrongAnswer.text = "Elephant";
            WrongAnswer2.text = "Hedgehog";
        }
        else if (prefabIndex == 15)
        {
            
            RightAnswer.text = "Dragonfly";
            WrongAnswer.text = "Bird";
            WrongAnswer2.text = "Beaver";
        }
        else if (prefabIndex == 16)
        {
            
            RightAnswer.text = "Duck";
            WrongAnswer.text = "BumbleBee";
            WrongAnswer2.text = "Black Bear";
        }
        else if (prefabIndex == 17)
        {
            
            RightAnswer.text = "Dugong";
            WrongAnswer.text = "Seal";
            WrongAnswer2.text = "Lion";
        }
        else if (prefabIndex == 18)
        {
           
            RightAnswer.text = "Elephant";
            WrongAnswer.text = "Whale";
            WrongAnswer2.text = "Donkey";
        }
        else if (prefabIndex == 19)
        {
            
            RightAnswer.text = "Giraffe";
            WrongAnswer.text = "Duck";
            WrongAnswer2.text = "Crab";
        }
        else if (prefabIndex == 20)
        {
            
            RightAnswer.text = "Hamster";
            WrongAnswer.text = "Donkey";
            WrongAnswer2.text = "Hedgehog";
        }
        else if (prefabIndex == 21)
        {
            
            RightAnswer.text = "Hedgehog";
            WrongAnswer.text = "Hamster";
            WrongAnswer2.text = "Ladybug";
        }
        else if (prefabIndex == 22)
        {
            
            RightAnswer.text = "Horse";
            WrongAnswer.text = "Cow";
            WrongAnswer2.text = "Donkey";
        }
        else if (prefabIndex == 23)
        {
            
            RightAnswer.text = "Ladybug";
            WrongAnswer.text = "Fly";
            WrongAnswer2.text = "Dragonfly";
        }
        else if (prefabIndex == 24)
        {
            
            RightAnswer.text = "";
            WrongAnswer.text = "";
            WrongAnswer2.text = "";
        }

        
    }

    public void animalAnswer()
    {
        
        Destroy(CurrentAnimal);
        int prefabIndex = UnityEngine.Random.Range(0, 24);
        CurrentAnimal = Instantiate(prefabList[prefabIndex]) as GameObject;
        if (prefabIndex == 0)
        {

            RightAnswer.text = "Lion";
            WrongAnswer.text = "Bat";
            WrongAnswer2.text = "Dog";


        }
        else if (prefabIndex == 1)
        {

            RightAnswer.text = "Beaver";
            WrongAnswer.text = "Otter";
            WrongAnswer2.text = "Lynx";
        }
        else if (prefabIndex == 2)
        {

            RightAnswer.text = "Beetle";
            WrongAnswer.text = "Fly";
            WrongAnswer2.text = "Wasp";
        }
        else if (prefabIndex == 3)
        {

            RightAnswer.text = "Bird";
            WrongAnswer.text = "Dinosaur";
            WrongAnswer2.text = "Emu";
        }
        else if (prefabIndex == 4)
        {

            RightAnswer.text = "Black Bear";
            WrongAnswer.text = "Brown Bear";
            WrongAnswer2.text = "Polar Bear";
        }
        else if (prefabIndex == 5)
        {

            RightAnswer.text = "Brown Bear";
            WrongAnswer.text = "Rat";
            WrongAnswer2.text = "Snake";
        }
        else if (prefabIndex == 6)
        {

            RightAnswer.text = "Buffalo";
            WrongAnswer.text = "Aligator";
            WrongAnswer2.text = "Zebra";
        }
        else if (prefabIndex == 7)
        {

            RightAnswer.text = "BumbleBee";
            WrongAnswer.text = "Wasp";
            WrongAnswer2.text = "Dragonfly";
        }
        else if (prefabIndex == 8)
        {

            RightAnswer.text = "Butterfly";
            WrongAnswer.text = "Dragon";
            WrongAnswer2.text = "Lion";
        }
        else if (prefabIndex == 9)
        {

            RightAnswer.text = "Chicken";
            WrongAnswer.text = "Bird";
            WrongAnswer2.text = "Cow";
        }
        else if (prefabIndex == 10)
        {

            RightAnswer.text = "Cow";
            WrongAnswer.text = "Duck";
            WrongAnswer2.text = "Horse";
        }
        else if (prefabIndex == 11)
        {

            RightAnswer.text = "Coyote";
            WrongAnswer.text = "Buffalo";
            WrongAnswer2.text = "Dalmation";
        }
        else if (prefabIndex == 12)
        {

            RightAnswer.text = "Crab";
            WrongAnswer.text = "Cow";
            WrongAnswer2.text = "Ladybug";
        }
        else if (prefabIndex == 13)
        {

            RightAnswer.text = "Dalmation";
            WrongAnswer.text = "Coyote";
            WrongAnswer2.text = "Brown Bear";
        }
        else if (prefabIndex == 14)
        {

            RightAnswer.text = "Donkey";
            WrongAnswer.text = "Elephant";
            WrongAnswer2.text = "Hedgehog";
        }
        else if (prefabIndex == 15)
        {

            RightAnswer.text = "Dragonfly";
            WrongAnswer.text = "Bird";
            WrongAnswer2.text = "Beaver";
        }
        else if (prefabIndex == 16)
        {

            RightAnswer.text = "Duck";
            WrongAnswer.text = "BumbleBee";
            WrongAnswer2.text = "Black Bear";
        }
        else if (prefabIndex == 17)
        {

            RightAnswer.text = "Dugong";
            WrongAnswer.text = "Seal";
            WrongAnswer2.text = "Lion";
        }
        else if (prefabIndex == 18)
        {

            RightAnswer.text = "Elephant";
            WrongAnswer.text = "Whale";
            WrongAnswer2.text = "Donkey";
        }
        else if (prefabIndex == 19)
        {

            RightAnswer.text = "Giraffe";
            WrongAnswer.text = "Duck";
            WrongAnswer2.text = "Crab";
        }
        else if (prefabIndex == 20)
        {

            RightAnswer.text = "Hamster";
            WrongAnswer.text = "Donkey";
            WrongAnswer2.text = "Hedgehog";
        }
        else if (prefabIndex == 21)
        {

            RightAnswer.text = "Hedgehog";
            WrongAnswer.text = "Hamster";
            WrongAnswer2.text = "Ladybug";
        }
        else if (prefabIndex == 22)
        {

            RightAnswer.text = "Horse";
            WrongAnswer.text = "Cow";
            WrongAnswer2.text = "Donkey";
        }
        else if (prefabIndex == 23)
        {

            RightAnswer.text = "Ladybug";
            WrongAnswer.text = "Fly";
            WrongAnswer2.text = "Dragonfly";
        }
        else if (prefabIndex == 24)
        {

            RightAnswer.text = "";
            WrongAnswer.text = "";
            WrongAnswer2.text = "";
        }

    }



    // Update is called once per frame
    void Update () {
		
	}
}
