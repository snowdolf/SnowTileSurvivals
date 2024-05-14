using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    public TMP_Text nameText;
    public GameObject jobSelectButton;
    public Sprite[] sprites;

    public void Select()
    {
        CharacterSelectManager.Instance.characterName = nameText.text;
        SceneManager.LoadScene("MainScene");
    }

    public void JobChange()
    {

        if(CharacterSelectManager.Instance.job == 0)
        {
            CharacterSelectManager.Instance.job = 1;
            GetComponent<Image>().sprite = sprites[1];
        }
        else
        {
            CharacterSelectManager.Instance.job = 0;
            GetComponent<Image>().sprite = sprites[0];
        }
    }
}
