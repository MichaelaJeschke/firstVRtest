using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControllerMichi : MonoBehaviour
{
    TargetManagerMichi manager;


    void Awake()
    {
        manager = GetComponentInParent<TargetManagerMichi>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ohoh")
        {
            print("Collision"); // GGF ENTFERNEN
            manager.TargetCollide(this);

        }
    }

}