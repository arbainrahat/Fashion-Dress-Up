using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{
    public GameObject EnablePanel;

    public void Enableit()
    {
        EnablePanel.SetActive(true);
    }
}
