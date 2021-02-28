using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScriptOpen : MonoBehaviour
{
    public GameObject Panel;
    public void PanelWork()
    {
        bool ActiveSelf = Panel.activeSelf;
        if (Panel != null)
        {
            Panel.SetActive(!ActiveSelf);
        }
    }
}
