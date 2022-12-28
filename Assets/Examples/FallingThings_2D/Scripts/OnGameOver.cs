using UnityEngine;
using UnityEngine.UI;

public class OnGameOver : MonoBehaviour
{
    private UIScript userInterface;
    [Header("Метка для вывода итогового кол-ва очков")]
    [SerializeField] private Text totalScore;

    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindObjectOfType<UIScript>();
        totalScore.text = userInterface.TotalScore.ToString();
        // Дурацкое Требование ТЗ:
        // (TODO: потом можно убрать - некрасиво)
        // 5. При поражении, объекты перестают падать, а, находящиеся на экране в данный момент, объекты исчезают, но
        // игрок не теряет очки или жизни.
        //var creator = GameObject.FindObjectOfType<ObjectCreatorArea>();
        //GameObject.FindGameObjectsWithTag(creator.prefabToSpawn.tag).ToList().ForEach(x => Destroy(x.gameObject));
        //Camera.main.gameObject.GetComponent<AudioSource>()?.Pause();
    }

}
