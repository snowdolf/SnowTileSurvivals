using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    public TMP_Text nameText;

    public void Select()
    {
        CharacterSelectManager.Instance.name = "nameText.text";
        SceneManager.LoadScene("MainScene");
    }
}
