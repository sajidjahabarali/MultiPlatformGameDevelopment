using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject checkpointTrigger;

    void OnTriggerEnter(){
        lapCompleteTrigger.SetActive(true);
        checkpointTrigger.SetActive(false);

    }
}
