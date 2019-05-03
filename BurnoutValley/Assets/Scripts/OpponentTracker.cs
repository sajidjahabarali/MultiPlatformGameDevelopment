using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentTracker : MonoBehaviour
{
    public GameObject Target;
	public GameObject Waypoint1;
	public GameObject Waypoint2;
	public GameObject Waypoint3;
	public GameObject Waypoint4;
	public GameObject Waypoint5;
	public GameObject Waypoint6;
    public GameObject Waypoint7;
    public GameObject Waypoint8;
    public GameObject Waypoint9;
    public GameObject Waypoint10;
    public GameObject Waypoint11;
    public GameObject Waypoint12;
    public GameObject Waypoint13;
    public GameObject Waypoint14;
    public GameObject Waypoint15;
    public GameObject Waypoint16;
    public GameObject Waypoint17;
    public GameObject Waypoint18;
    public GameObject Waypoint19;
    public GameObject Waypoint20;
    public GameObject Waypoint21;
    public GameObject Waypoint22;
    public GameObject Waypoint23;


	public int tracker;

	void Update () {
		if (tracker == 0) {
			Target.transform.position = Waypoint1.transform.position;
		}
		if (tracker == 1) {
			Target.transform.position = Waypoint2.transform.position;
		}
		if (tracker == 2) {
			Target.transform.position = Waypoint3.transform.position;
		}
		if (tracker == 3) {
			Target.transform.position = Waypoint4.transform.position;
		}
		if (tracker == 4) {
			Target.transform.position = Waypoint5.transform.position;
		}
        if (tracker == 5) {
			Target.transform.position = Waypoint6.transform.position;
		}
		if (tracker == 6) {
			Target.transform.position = Waypoint7.transform.position;
		}
        if (tracker == 7) {
			Target.transform.position = Waypoint8.transform.position;
		}
        if (tracker == 8) {
			Target.transform.position = Waypoint9.transform.position;
		}
        if (tracker == 9) {
			Target.transform.position = Waypoint11.transform.position;
		}
        if (tracker == 10) {
			Target.transform.position = Waypoint11.transform.position;
		}
        if (tracker == 11) {
			Target.transform.position = Waypoint13.transform.position;
        }
        if (tracker == 12) {
			Target.transform.position = Waypoint13.transform.position;
		}
        if (tracker == 13) {
			Target.transform.position = Waypoint14.transform.position;
		}
        if (tracker == 14) {
			Target.transform.position = Waypoint15.transform.position;
		}
        if (tracker == 15) {
			Target.transform.position = Waypoint16.transform.position;
		}
        if (tracker == 16) {
			Target.transform.position = Waypoint17.transform.position;
		}
        if (tracker == 17) {
			Target.transform.position = Waypoint18.transform.position;
		}
        if (tracker == 18) {
			Target.transform.position = Waypoint19.transform.position;
		}
        if (tracker == 19) {
			Target.transform.position = Waypoint20.transform.position;
		}
        if (tracker == 20) {
			Target.transform.position = Waypoint21.transform.position;
		}
        if (tracker == 21) {
			Target.transform.position = Waypoint22.transform.position;
		}
        if (tracker == 22) {
			Target.transform.position = Waypoint23.transform.position;
		}
		
	}

	IEnumerator OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "OpponentCar") {
			this.GetComponent<BoxCollider>().enabled = false;
			if((tracker==9)||(tracker==11)){
                tracker += 2;
            }else{
                tracker += 1;
            }
			if (tracker == 23) {
				tracker = 0;
			}
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	}
}