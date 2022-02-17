using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollector : MonoBehaviour
{
    public bool hasKey = false;

    public void ReceiveKey(){
        hasKey = true;
    }

}
