using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredTrigger : MonoBehaviour
{
    public bool enteredTrigger;

    public void OnTriggerEnter(Collider c) {
        if (c.CompareTag("trigger")) {
            enteredTrigger = true;
        }
    }
}
