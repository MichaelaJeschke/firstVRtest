using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF;

public class TargetManagerMichi : MonoBehaviour
{

    // public TargetControllerMichi leftTarget; // noch ein skript targetcontrollermichi machen. wofuer aktuell denn eig
    // public TargetControllerMichi rightTarget;
   //public TargetControllerMichi CubyOne;
  //  public TargetControllerMichi CubyTwo;
    public Session session;
    public TargetControllerMichi target;


    // Start is called before the first frame update
  

    // Update is called once per frame
    
   /// public void OnCollisionEnter(Collision collision)
  //  {
  //      if (collision.gameObject.tag == "ohoh")
  //      {
  //          print("Collision");
   //         Trial currentTrial = session.CurrentTrial;
   //         currentTrial.End();


  //      }
  //  }
//}

public void TargetCollide(TargetControllerMichi target)
{
    Trial currentTrial = session.CurrentTrial;
    currentTrial.End();
       // session.BeginNextTrial();
}
}