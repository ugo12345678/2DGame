using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text FruitText;

    public Animator Animator;

    private int _fruitCount = 0;

    public GameObject Player;

    public RuntimeAnimatorController LittleAnimator;

    public RuntimeAnimatorController BigAnimator;

    public Collider2D BigCollider;
    public Collider2D LittleCollider;

    private void Awake()
    {
        // Si jamais on charge une 2e scene
        // avec un autre GameManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddFruit()
    {
        FruitText.text = $"Pieces: {++_fruitCount}";
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void UpPlayer()
    {
        Animator.runtimeAnimatorController = BigAnimator;
        BigCollider.isTrigger = false;
        LittleCollider.isTrigger = true;
    }

}
