/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typewriting_effect : MonoBehaviour
{
    //[SerializeField] TextMeshProGUI textMeshPro;
    public string[] stringArray;
    [SerializeField] float timeBetweenChars;
    [SerializeField] float timeBetweenWords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void EndCheck(){
    
    }

    private IEnumerator TextVisible(){
        int totalVisChar= textMeshPro.textInfo.characterCount;
        int counter=0;

        while(true){
            int visibleCount=counter% (totalVisChar +1);
            textMeshPro.maxVisibleCharacters=visibleCount;

            if(visibleCount>=totalVisChar)
            {
                Invoke("EndCheck", timeBetweenWords);
                break;
            }

            counter+=1;
            yield return new WaitForSeconds(timeBetweenChars);
        }
    }
}
*/