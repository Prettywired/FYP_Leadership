using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionClicked : MonoBehaviour
{
   public List<Button> choiceButtons;
   int[] scores={5,3,7,10};
    public Color selectedColor = Color.white;
    public Color dimmedColor = new Color(1f, 1f, 1f, 0.5f); // white but semi-transparent
    public Button submission;

    private int selectedIndex = -1;

    void Start()
    {
        for (int i = 0; i < choiceButtons.Count; i++)
        {
            int index = i;
            choiceButtons[i].onClick.AddListener(() => OnChoiceSelected(index));
        }
        submission.interactable=false;

        ResetChoices();
    }

    void OnChoiceSelected(int index)
    {
        selectedIndex = index;

        for (int i = 0; i < choiceButtons.Count; i++)
        {
            var image = choiceButtons[i].GetComponent<Image>();
            if (image != null) //make sure image component isn't empty
            {
                image.color = (i == index) ? selectedColor : dimmedColor; //checks whether that button is the button we want or not, if not it'll be dimmed
            }
        }
        submission.interactable=true;
    }


    public void OnSubmit(){
        Accumulated_score.score+=scores[selectedIndex];
        Scene_Manager.scene+=1;
        Debug.Log(Accumulated_score.score);
    }
    
    void ResetChoices()
    {
        foreach (var btn in choiceButtons)
        {
            var image = btn.GetComponent<Image>();
            if (image != null)
            {
                image.color = selectedColor;
            }
        }
    }
   
}
