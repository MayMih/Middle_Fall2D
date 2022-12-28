using UnityEngine;
using UnityEngine.UI;

public class OnGameOver : MonoBehaviour
{
    private UIScript userInterface;
    [Header("����� ��� ������ ��������� ���-�� �����")]
    [SerializeField] private Text totalScore;

    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindObjectOfType<UIScript>();
        totalScore.text = userInterface.TotalScore.ToString();
        // �������� ���������� ��:
        // (TODO: ����� ����� ������ - ���������)
        // 5. ��� ���������, ������� ��������� ������, �, ����������� �� ������ � ������ ������, ������� ��������, ��
        // ����� �� ������ ���� ��� �����.
        //var creator = GameObject.FindObjectOfType<ObjectCreatorArea>();
        //GameObject.FindGameObjectsWithTag(creator.prefabToSpawn.tag).ToList().ForEach(x => Destroy(x.gameObject));
        //Camera.main.gameObject.GetComponent<AudioSource>()?.Pause();
    }

}
