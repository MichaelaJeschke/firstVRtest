using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF; // wichtig diese library hinzuzuf�gen

public class generateexperiment : MonoBehaviour
{

    // hier generieren wir die bl�cke und trials der session.  the session is passed as an argument by the event call
    public void Generate(Session session)
        {

        int numTrials = 5;
        session.CreateBlock(numTrials);            // die 5 in klammern ist anzahl trials

        // foreach (Trial trial in myBlock.trials)
        //{
        // blabla
        // }
    }
}
