using UnityEditor.Animations;
using UnityEngine;

public class PlayerJobController : MonoBehaviour
{
    [SerializeField] private GameObject mainSprite;
    private SpriteRenderer characterSpriteRenderer;
    private Animator characterAnimator;

    public Sprite[] sprites;
    public AnimatorController[] animators;

    private void Awake()
    {
        characterSpriteRenderer = mainSprite.GetComponent<SpriteRenderer>();
        characterAnimator = mainSprite.GetComponent<Animator>();
    }

    private void Start()
    {
        if(CharacterSelectManager.Instance.job == 0)
        {
            mainSprite.transform.localScale = new Vector3(1f, 1f, 1f);
            characterSpriteRenderer.sprite = sprites[0];
            characterAnimator.runtimeAnimatorController = animators[0];
        }
        else
        {
            mainSprite.transform.localScale = new Vector3(2f, 2f, 1f);
            characterSpriteRenderer.sprite = sprites[1];
            characterAnimator.runtimeAnimatorController = animators[1];

            GetComponent<BoxCollider2D>().offset = new Vector2(0f, 1f);
            GetComponent<BoxCollider2D>().size = new Vector2(0.8f, 1.2f);
        }
    }
}