using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

	public Button playButton;
	// Use this for initialization
	void Start () {
		Button button = playButton.GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);
	}

	//What happens when you click the playButton;
	void TaskOnClick(){
		SceneManager.LoadSceneAsync("MainGame");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
