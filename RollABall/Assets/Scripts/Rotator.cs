using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    //Update is called once per frame.
    void Update(){
        //rotate the object
        transform.Rotate(new Vector3(15, 30, 45));
    }
}
