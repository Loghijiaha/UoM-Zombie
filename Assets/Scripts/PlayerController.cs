using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed = 4f;
	private Vector3 facing = Vector3.zero;
	public int health;
	public int score;
	public TextMesh scoreText;
	public TextMesh healthText;
	public int inc;
	public int dec_health;
    	public static PlayerController instance = null; 	
	void Start() {

	score = 0;
	health = 100;
	inc = 3;
	dec_health = 0;
	scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<TextMesh>();
	healthText = GameObject.FindGameObjectWithTag("Health").GetComponent<TextMesh>();
	scoreText.text = "Score   "+score.ToString(); 
	healthText.text = "Health  "+health.ToString();
	}
	// Update is called once per frame
	
	void Awake(){
	             //Check if instance already exists
             if (instance == null)
             {
                 //if not, set instance to this
		DontDestroyOnLoad(gameObject);
                 instance = this;
             }
             //If instance already exists and it's not this:
             else if (instance != this)
             {
                Destroy(gameObject);   
             }
 
             
	}
	void Update () {

	score = score+inc;
	health = health - dec_health;
 	scoreText.text = "Score   "+score.ToString(); 
	healthText.text ="Health  "+health.ToString();
	
	if(health == 0){
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
        // Quit if the player presses Escape
        if (Input.GetKey("escape"))
            Application.Quit();
 
        // Get input from the keyboard or controller
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
 
        // Calculate the angle to rotate the player
        Vector3 facing = new Vector3(h, v, 0);
        float angle = Mathf.Atan2(facing.y, facing.x) * Mathf.Rad2Deg;
 
        // Rotate the player
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
 
        // Move the player
        transform.Translate(facing * speed * Time.deltaTime, Space.World);
    }

	void OnCollisionEnter2D(Collision2D col)
	{

	if (col.gameObject.tag == "property")
        {
           	facing = Vector3.zero;
		this.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		speed=0f;
        }
   	 
	}
}
