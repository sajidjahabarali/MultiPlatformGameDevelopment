using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarStart : MonoBehaviour {

    public GameObject CarControl;
    public GameObject OpponentCar;


    void Start () {
        CarControl.GetComponent<CarController>().enabled = true;
        OpponentCar.GetComponent<CarAIControl>().enabled = true;

    }
}