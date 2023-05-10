using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used to switch scenes
using UnityEngine.SceneManagement;
 
public class SplashScreen : MonoBehaviour {
 
	// The next scene to load
	public string sceneToLoad;
 
	// Time to pause before loading next scene in seconds
	public int secTillSceneLoad;
 
	// Use this for initialization
	void Start () {
 
		// Call function OpenNextScene after a set number of seconds
		Invoke("OpenNextScene", secTillSceneLoad);
	}
	
	// Update is called once per frame
	void OpenNextScene () {
 
		// Load defined scene
		SceneManager.LoadScene(sceneToLoad);
 
	}
}