using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Loot : MonoBehaviour {


    private Rect inventoryWindowsRect = new Rect(300, 100, 400, 400);
    private bool inventoryWindowToggle = false;

    //private dictonary of the items
    public Dictionary<int, string> lootDictionary = new Dictionary<int, string>()
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
    private List<int> lootDictionaryAmounts = new List<int>()
    {
        0,
        0,
        0,
        0,
        0
    };

    ItemClass itemObject = new ItemClass();

    private Ray mouseRay;
    private RaycastHit rayHit;

    void Start()
    {
        lootDictionary[0] = itemObject.axeItem.itemName;
        lootDictionaryAmounts[0] = 10;
        lootDictionary[1] = itemObject.arrowItem.itemName;
        lootDictionaryAmounts[1] = 10;
    }
    void Update()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            Physics.Raycast(mouseRay, out rayHit);
            if(rayHit.collider.transform.tag == "LootableCorpse")
            {
                inventoryWindowToggle = true;
            }
        }
        //Close loot window
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inventoryWindowToggle = false;
        }
    }
    void OnGUI()
    {
        if (inventoryWindowToggle)
        {
            inventoryWindowsRect = GUI.Window(0, inventoryWindowsRect, inventoryWindowMethod, "Loot Corps");
        }
    }

    private void inventoryWindowMethod(int windowId)
    {
        //lootDictionary[0] = itemObject.axeItem.name;
        GUILayout.BeginArea(new Rect(10, 50, 380, 400));

        GUILayout.BeginHorizontal();
            if (GUILayout.Button(lootDictionary[0], GUILayout.Height(50)))
            {
                if (lootDictionary[0] != string.Empty && lootDictionaryAmounts[0] !=0)
                {
                    InventoryGUI.inventoryNameDictionary[0] = lootDictionary[0];
                    if(lootDictionaryAmounts[0] != 0)
                    {
                        lootDictionaryAmounts[0] -= 1;
                        InventoryGUI.dictionaryAmounts[0] += 1;
                    }
                }
                if(lootDictionaryAmounts[0] == 0)
                {
                lootDictionary[0] = string.Empty;
                }
            }
        GUILayout.Box(lootDictionaryAmounts[0].ToString(), GUILayout.Height(50));

        if (GUILayout.Button(lootDictionary[1], GUILayout.Height(50)))
        {
            if (lootDictionary[1] != string.Empty && lootDictionaryAmounts[1] != 0)
            {
                InventoryGUI.inventoryNameDictionary[1] = lootDictionary[1];
                if (lootDictionaryAmounts[1] != 0)
                {
                    lootDictionaryAmounts[1] -= 1;
                    InventoryGUI.dictionaryAmounts[1] += 1;
                }
            }
            if (lootDictionaryAmounts[1] == 0)
            {
                lootDictionary[1] = string.Empty;
            }
        }
        GUILayout.Box(lootDictionaryAmounts[1].ToString(), GUILayout.Height(50));

        if (GUILayout.Button(lootDictionary[2], GUILayout.Height(50)))
        {
            if (lootDictionary[2] != string.Empty && lootDictionaryAmounts[2] != 0)
            {
                InventoryGUI.inventoryNameDictionary[2] = lootDictionary[2];
                if (lootDictionaryAmounts[2] != 0)
                {
                    lootDictionaryAmounts[2] -= 1;
                    InventoryGUI.dictionaryAmounts[2] += 1;
                }
            }
            if (lootDictionaryAmounts[2] == 0)
            {
                lootDictionary[2] = string.Empty;
            }
        }
        GUILayout.Box(lootDictionaryAmounts[2].ToString(), GUILayout.Height(50));

        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }

}
