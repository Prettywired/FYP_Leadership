using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_changes : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;

    public void QuesChange(){
        Q1.SetActive(false);
        Q2.SetActive(true);
    } 
}
