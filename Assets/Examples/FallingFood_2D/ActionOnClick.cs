using UnityEngine;

public class ActionOnClick : MonoBehaviour
{
    [SerializeField] private GameObject objN1;
    [SerializeField] private GameObject objN2;
    [SerializeField] private GameObject objBomb;

    private UIScript userInterface;
    private HealthSystemAttribute healhSystem;

    private void Start()
    {
        healhSystem = GameObject.FindObjectOfType<HealthSystemAttribute>();
        userInterface = GameObject.FindObjectOfType<UIScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            //Debug.Log($"{this.name} detected Left mouse button Click on {col?.name}!");
            if (col == null)
            {
                return;
            }
            if (col.CompareTag(objN1.tag) || col.CompareTag(objN2.tag) || col.CompareTag(objBomb.tag))
            {
                var act = col.GetComponent<CollectAction>();
                if (act != null)
                {
                    act.ExecuteAction(gameObject);
                    if (act.lifeImpact != 0)
                    {
                        healhSystem.ModifyHealth(act.lifeImpact);
                    }
                    else if (act.scoreImpact != 0)
                    {
                        userInterface.AddPoints(act.scoreImpact);
                    }
                }                
            }            
        }
    }
}
