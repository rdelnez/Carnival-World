using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SVM_Script : MonoBehaviour
{

	public string gameDifficulty;
	
	public static SVM_Script Instance
	{
		get;
		private set;
	}

	public GameObject canvas;
	private GameObject loadingScreen;

	/// <summary>
	/// Target time to beat in seconds.
	/// </summary>
	

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
		if (Instance == null)
		{
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
		
	//	SceneManager.sceneLoaded += SceneLoadListener;
	//	SetUpLoadingScreen();           //Establish the loading screen and attach it to the canvas while fixing strange value artifacts
	//	InitializeSavedVariables();     //Initialize variables that needs to be saved when APP is closed
	//	LoadSavedVariables();           //Load the variables from Playerprefs
	
	}

	void SetUpLoadingScreen()
	{
		canvas = GameObject.FindGameObjectWithTag("Canvas");
		loadingScreen = Instantiate(Resources.Load("prefabs/LoadingScreen")) as GameObject;
		loadingScreen.name = "Loading Screen";
		loadingScreen.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		loadingScreen.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		loadingScreen.GetComponent<RectTransform>().sizeDelta = new Vector2(800, 450);
		loadingScreen.transform.SetParent(canvas.transform);
		loadingScreen.GetComponent<RectTransform>().localPosition = Vector3.zero;
		loadingScreen.GetComponent<RectTransform>().localScale = Vector3.one;
		loadingScreen.SetActive(false);
	}


	void SceneLoadListener(Scene scene, LoadSceneMode loadMode)
	{
		SetUpLoadingScreen();
	}

	/*--
	public void InitializeSavedVariables()
	{
		if (!PlayerPrefs.HasKey("EE_advance"))
		{
			PlayerPrefs.SetInt("EE_advance", 0);
		}
		if (!PlayerPrefs.HasKey("EE_expert"))
		{
			PlayerPrefs.SetInt("EE_expert", 0);
		}
		if (!PlayerPrefs.HasKey("Instructions_Dismissed"))
		{
			PlayerPrefs.SetInt("Instructions_Dismissed", 0);
		}
	}

	public void LoadSavedVariables()
	{
		if (PlayerPrefs.GetInt("EE_advance") == 1)
		{
			advanceIsLocked = false;
		}
		else
		{
			advanceIsLocked = true;
		}

		if (PlayerPrefs.GetInt("EE_expert") == 1)
		{
			expertIsLocked = false;
		}
		else
		{
			expertIsLocked = true;
		}
		if (PlayerPrefs.GetInt("Instructions_Dismissed") == 1)
		{
			InstructionSeen = true;
		}
		else
		{
			InstructionSeen = false;
		}
	}
	--*/
	public void LoadLevel(string levelName)
	{
		if (!loadingScreen)
		{
			Debug.LogError("Loading Screen has not been set up");
			return;
		}
		loadingScreen.SetActive(true);
		StartCoroutine(LevelLoader(levelName));
	}

	IEnumerator LevelLoader(string levelName)
	{
		yield return new WaitForSeconds(0.5f);
		AsyncOperation async = SceneManager.LoadSceneAsync(levelName);
		yield return async;
	}

}
