using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    private UIScript userInterface;
    private HealthSystemAttribute healhSystem;
    [Header("Метка для вывода итогового кол-ва очков")]
    [SerializeField] private Text totalScore; 

    // Start is called before the first frame update
    void Start()
    {
        healhSystem = GameObject.FindObjectOfType<HealthSystemAttribute>();
        userInterface = GameObject.FindObjectOfType<UIScript>();
        totalScore.text = userInterface.TotalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
