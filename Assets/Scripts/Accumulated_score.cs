using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accumulated_score : MonoBehaviour
{
    public static int score=0;

    public void sendScore(){
        //api call to send score
        string jsCode= $"window.parent.postMessage({{type: 'UPDATE_LEADERSHIP_SCORE', score:{score}}}, '*');";
        Application.ExternalEval(jsCode);
    }
}
