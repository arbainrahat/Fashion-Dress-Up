using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    public GameObject Animator;

    public void StopAnim()
    {
        Animator.GetComponent<Animator>().enabled = false;
    }
}
