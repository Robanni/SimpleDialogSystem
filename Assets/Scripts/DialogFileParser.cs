using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogFileParser", menuName = "DialogFileParser",order = 51)]
public class DialogFileParser : ScriptableObject
{
    [SerializeField]
    private string Patch = @"Resources\XML\var.xml";

    private XmlDocument Doc;

    
    public List<string> GetDialogText()
    {
        string FullPatch = Application.dataPath + "\\" + Patch;
        List<string> DialogData = new List<string>();

        if (!File.Exists(FullPatch))
        {
            Debug.LogError("File not found");
            return null;
            //throw new FileNotFoundException(Patch);
        }

        Doc = new XmlDocument();
        Doc.Load(FullPatch);

        XmlElement Root = Doc.DocumentElement;
        XmlNodeList XNL = Root.ChildNodes;

        for (int i = 0; i < XNL.Count; i++)
        {
            DialogData.Add( XNL.Item(i).InnerText);
        }
        return DialogData;
    }
}
