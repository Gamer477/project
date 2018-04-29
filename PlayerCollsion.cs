using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsion : MonoBehaviour {
    public PlayerMovement movment;
    void OnCollisionEnter(Collision collisiioninfo)
    {
        if (collisiioninfo.collider.tag == "cube")
        {
            movment.enabled = false;
            Debug.Log("sssdssda");
          
        }
    }
}
