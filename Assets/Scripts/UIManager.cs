using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private List<Animator> _buttonList;
    [SerializeField]
    private string _appearAnimationName = "UIObjectAppear";
    [SerializeField]
    private string _disappearAnimationName = "UIObjectDisappear";

    public void ShowButtons()
    {
        foreach (Animator button in _buttonList)
        {
            button.Play(_appearAnimationName);
        }
    }

    public void HideButtons()
    {
        foreach (Animator button in _buttonList)
        {
            button.Play(_disappearAnimationName);
        }
    }
}
