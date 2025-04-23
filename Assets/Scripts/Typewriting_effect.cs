using System.Collections;
using TMPro;
using UnityEngine;

public class Typewriting_effect : MonoBehaviour
{
    public TMP_Text textComponent;
    [TextArea]
    private string fullText;
    public float typingSpeed = 0.05f;

    private void Start()
    {
        fullText = textComponent.text;
        StartCoroutine(PlayTypewriter());
    }

    IEnumerator PlayTypewriter()
    {
        textComponent.text = "";
        foreach (char c in fullText)
        {
            textComponent.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
