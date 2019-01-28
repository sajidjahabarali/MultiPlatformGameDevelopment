using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    //speed is a public variable
    public float speed;
    private int count;
    public float xPos;
    public float yPos;
    public float zPos;
    public float velocity;
    private int numPickups = 3;
    public Text scoreText;
    public Text winText;
    public Text posText;
    public Text velText;
    //public Vector3 previousPos;

    void Start(){
        count = 0;
        xPos = 0;
        yPos = 0;
        zPos = 0;
        
        winText.text = "";
        SetCountText();
        setPosText();
        //setVelText();



    }

    //coding in FixedUpdate() function as the operations involve physics
    void FixedUpdate(){
        //takes input from arrow keys
        float horAxis = Input.GetAxis ("Horizontal");
        float verAxis = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (horAxis, 0.0f, verAxis);

        /***
        Move player by applying a physics force.
        Time.deltaTime contains the time since the last update call and assures a smooth movement.
        ***/
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        setPosText();

    }

    //function which is called when other game objects collider, configured as trigger, collides with the collider of the game oject that has this script as a component.
    void OnTriggerEnter(Collider other){

        //check if we are colliding with a pickup
        if(other.gameObject.tag == "PickUp"){
            //if we are colliding with a pickup, set game object to inactive to simulate object being picked up.
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

    }

    private void SetCountText(){

        scoreText.text = "Score: " + count.ToString();
        if(count>=numPickups){
            winText.text = "You Win!";
        }

    }

    private void setPosText(){

        posText.text = "X: " + transform.position.x.ToString() + " Z: " + transform.position.z.ToString();

    }

    private void setVelText(){

        //velText.text = "Velocity: " + ((transform.position-previousPos)/Time.deltaTime);
        //velText.text = "Velocity: " + GetComponent<Rigidbody>().velocity.toString();
    }
}