using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour {

	private Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.FindGameObjectWithTag("final").GetComponent<Text>();
		long score = PlayerController.instance.score;
		scoreText.text="Score   "+score.ToString(); 
		
	
	}
	
	void Update () {
	 Destroy(GameObject.Find("player"));
	}
}
