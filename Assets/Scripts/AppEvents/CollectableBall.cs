using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBall : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c) {
        if (c.attachedRigidbody != null){
            BallCollector bc = c.attachedRigidbody.gameObject.GetComponent<BallCollector>();
            bc.ReceiveBall();
            EventManager.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);
            Destroy(this.gameObject);
        }
    }

}
