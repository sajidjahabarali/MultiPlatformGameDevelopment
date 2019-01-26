using UnityEngine ;
using System . Collections ;

public class CameraController : MonoBehaviour {

    //player is the target of the camera
    public GameObject player ;

    //private offset from the player to the camera
    private Vector3 offset ;
    
    //start to initialize the offset. This takes the initial position of the camera. we can use this vecotr as originally the player is at the origin. 
    void Start () {
        
        offset = transform . position ;
    }

    void LateUpdate () {
        transform . position = player . transform . position + offset ;
    }
 }