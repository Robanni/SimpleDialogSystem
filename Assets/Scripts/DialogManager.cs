using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    [SerializeField]
    private DialogFileParser dialogData;
    void Start()
    {
        List<string> list = dialogData.GetDialogText();
        for(int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
