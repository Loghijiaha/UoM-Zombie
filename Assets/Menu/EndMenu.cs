using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

	public void rePlayGame(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}

	public void quitGame(){
		Application.Quit();
	}

}
