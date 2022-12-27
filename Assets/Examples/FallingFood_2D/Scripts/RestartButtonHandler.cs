using UnityEngine;

public class RestartButtonHandler : MonoBehaviour
{
    private UIScript userInterface;
    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindObjectOfType<UIScript>();
    }

    
    public void OnButtonClick()
    {
        userInterface.Restart();
    }
}
