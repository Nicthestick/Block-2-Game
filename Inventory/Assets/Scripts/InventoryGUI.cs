using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGUI : MonoBehaviour {

    private Rect inventoryWindowsRect = new Rect(300, 100, 400, 400);
    private bool inventoryWindowToggle = false;
    public int baggSpace = 10;

    //private dictonary of the items
    static public Dictionary<int, string> inventoryNameDictionary = new Dictionary<int, string>()
        {
            {0,string.Empty},
            {1,string.Empty},
            {2,string.Empty },
            {3,string.Empty},
            {4,string.Empty },
            {5,string.Empty},
            {6,string.Empty },
            {7,string.Empty },
            {8,string.Empty },
            {9,string.Empty }
        };
    static public List<int> dictionaryAmounts = new List<int>()
    {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0
    };
    ItemClass itemObject = new ItemClass();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            inventoryWindowToggle = true;
        }
        //Close loot window
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                inventoryWindowToggle = false;            
        }
    }
    void OnGUI()
    {
        inventoryWindowToggle = GUI.Toggle(new Rect(800, 50, 100, 50), inventoryWindowToggle, "Inventory");
        if (inventoryWindowToggle)
        {
            inventoryWindowsRect = GUI.Window(0, inventoryWindowsRect, inventoryWindowMethod, "Inventory");
        }
    }

    private void inventoryWindowMethod(int windowId)
    {
        GUILayout.BeginArea(new Rect(10, 50, 380, 400));

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[0], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[0].ToString(), GUILayout.Height(50));
        GUILayout.EndHorizontal();
        //First line of bagg space
        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[1], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[1].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[2], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[2].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[3], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[3].ToString(), GUILayout.Height(50));
        GUILayout.EndHorizontal();
        //Second line of bagg space
        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[4], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[4].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[5], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[5].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[6], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[6].ToString(), GUILayout.Height(50));
        GUILayout.EndHorizontal();
        //Thirth line of bagg space
        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[7], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[7].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[8], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[8].ToString(), GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[9], GUILayout.Height(50));
        GUILayout.Box(dictionaryAmounts[9].ToString(), GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }

}
