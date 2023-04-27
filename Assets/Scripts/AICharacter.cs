using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacter : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    private void OnEnable()
    {
        RandomGenerate();
    }

    private void RandomGenerate()
    {
        foreach (GameObject go in items)
        {
            go.SetActive(false);
        }

        int rand = Random.Range(0, items.Length);
        items[rand].SetActive(true);
    }
}
