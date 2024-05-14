using TMPro;
using UnityEngine;

public class PlayerTextController : MonoBehaviour
{
    [SerializeField]private TMP_Text nameText;

    private void Start()
    {
        nameText.text = CharacterSelectManager.Instance.characterName;
    }
}
