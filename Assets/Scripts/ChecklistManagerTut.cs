using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecklistManagerTut : MonoBehaviour
{
    public Transform content;
    public GameObject addPanel;
    public Button createButton;
    public GameObject checklistItemPrefab;

    string filePath;

    private List<ChecklistObjectTut> checklistObjects = new List<ChecklistObjectTut>();

    private void Start()
    {
        filePath = Application.persistentDataPath + "/checklist.txt";
    }

}
