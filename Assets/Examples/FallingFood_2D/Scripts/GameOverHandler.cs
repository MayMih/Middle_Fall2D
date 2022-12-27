using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    private UIScript userInterface;
    [Header("Метка для вывода итогового кол-ва очков")]
    [SerializeField] private Text totalScore;    

    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindObjectOfType<UIScript>();
        totalScore.text = userInterface.TotalScore.ToString();
    }

}
