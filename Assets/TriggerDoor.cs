using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour {

    [SerializeField] private Animator myAnimationController;
    private GameObject player;

    void Start() {

        player = GameObject.FindWithTag("Player");
        myAnimationController = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider c) {

        if (c.CompareTag("Player")) {
            myAnimationController.SetBool("PlayerEntered", true);
        }
        

    }

    private void OnTriggerExit(Collider c) {

        if (c.CompareTag("Player")) {

            myAnimationController.SetBool("PlayerEntered", false);
        }
    }

}
