using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    #region DataFields
    [Header("UI")]
    [SerializeField] private GameObject[] sideScrolls;
    [SerializeField] private Sprite[] avatar;
    [SerializeField] private Image competetiorAvatar;
    [SerializeField] private GameObject findPlayerScreen;
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private Text avatarName;
    [SerializeField] private string[] avatarNames;
    [SerializeField] private Text avatarNameComplete;
    [SerializeField] private Image competetiorAvatarComplete;

    [Header("References")]
    [SerializeField] private GameObject[] hair;
    [SerializeField] private GameObject[] dress;
    [SerializeField] private GameObject[] shoes;
    [SerializeField] private GameObject[] eyes;
    [SerializeField] private GameObject[] lipstick;
    [SerializeField] private GameObject[] eyeLash;
    [SerializeField] private GameObject[] neckless;
    [SerializeField] private GameObject[] earrings;

    [SerializeField] private GameObject gamePlayData;

    #endregion

    #region Methods

    public void OnSelectItem(int index)
    {
        foreach (GameObject go in sideScrolls)
        {
            go.SetActive(false);
        }
        sideScrolls[index].SetActive(true);
    }

    public void OnSelectHair(int index)
    {
        foreach (GameObject go in hair)
        {
            go.SetActive(false);
        }
        hair[index].SetActive(true);
    }

    public void OnSelectDress(int index)
    {
        foreach (GameObject go in dress)
        {
            go.SetActive(false);
        }
        dress[index].SetActive(true);
    }

    public void OnSelectShoe(int index)
    {
        foreach (GameObject go in shoes)
        {
            go.SetActive(false);
        }
        shoes[index].SetActive(true);
    }

    public void OnSelectEye(int index)
    {
        foreach (GameObject go in eyes)
        {
            go.SetActive(false);
        }
        eyes[index].SetActive(true);
    }

    public void OnSelectLipstick(int index)
    {
        foreach (GameObject go in lipstick)
        {
            go.SetActive(false);
        }
        lipstick[index].SetActive(true);
    }

    public void OnSelectEyeLash(int index)
    {
        foreach (GameObject go in eyeLash)
        {
            go.SetActive(false);
        }
        eyeLash[index].SetActive(true);
    }

    public void OnSelectNeckless(int index)
    {
        foreach (GameObject go in neckless)
        {
            go.SetActive(false);
        }
        neckless[index].SetActive(true);
    }

    public void OnSelectEarring(int index)
    {
        foreach (GameObject go in earrings)
        {
            go.SetActive(false);
        }
        earrings[index].SetActive(true);
    }

    public void OffLipstick()
    {
        foreach (GameObject go in lipstick)
        {
            go.SetActive(false);
        }
    }

    public void OffEyeLash()
    {
        foreach (GameObject go in eyeLash)
        {
            go.SetActive(false);
        }
    }

    public void StartBtn()
    {
        FindEnemy();
    }

    private void FindEnemy()
    {
        findPlayerScreen.SetActive(true);
        int rand = Random.Range(0, avatar.Length);
        StartCoroutine(ChangeAvatar(rand));
    }

    IEnumerator ChangeAvatar(int index)
    {
        for (int i = 0; i < index + 1; i++)
        {
            competetiorAvatar.sprite = avatar[i];
            yield return new WaitForSeconds(0.2f);
        }
        int rad = Random.Range(0, avatarNames.Length);
        avatarName.text = avatarNames[rad];
        avatarName.gameObject.SetActive(true);

        //win Screen Implementation
        avatarNameComplete.text = avatarNames[rad];
        competetiorAvatarComplete.sprite = avatar[index];

        yield return new WaitForSeconds(1f);
        findPlayerScreen.SetActive(false);
        mainMenuUI.SetActive(false);
        gameplayUI.SetActive(true);
        gamePlayData.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    #endregion
}
