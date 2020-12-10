using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter (Collider name)
    {
        // Add is trigger

        var boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
