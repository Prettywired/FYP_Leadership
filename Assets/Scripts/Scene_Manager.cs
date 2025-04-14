using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Manager : MonoBehaviour
{
    public static int scene=0;
    public List<string> scene_1_dialogues;
    public List<string> scene_2_dialogues;
    public List<string> scene_3_dialogues;
    public List<string> scene_4_dialogues;
    public List<string> scene_5_dialogues;
    public List<string> scene_6_dialogues;
    public List<string> scene_7_dialogues;
    public List<string> scene_8_dialogues;

    public static void ChangeScene(){
        scene+=1;
        
    }
    
}
