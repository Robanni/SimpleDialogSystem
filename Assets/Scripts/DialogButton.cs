using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine;


public class DialogButton : MonoBehaviour
{
    [SerializeField]
    private DialogFileParser dialogData;
    [SerializeField]
    private TextMeshProUGUI dialogTextField;
    [SerializeField]
    private Canvas DialogCanvas;
    private List<string> list;
    private int dialogIndex = 0;

    void Start()
    {
        list = dialogData.GetDialogText();
    }

    public void ShowDialogText()
    {
        if(dialogIndex < list.Count)
        {
            Debug.Log(list.Count);
            Debug.Log(dialogIndex);
            dialogTextField.text = list[dialogIndex];
            dialogIndex++;
            return;
        }
        DialogCanvas.enabled = false;      
    }

}
