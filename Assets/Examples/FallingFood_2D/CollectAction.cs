using UnityEngine;

[AddComponentMenu("Playground/Actions/Collect Action")]
public class CollectAction : Action
{
    // assign an effect (explosion? particles?) or object to be created (instantiated) when the one gets destroyed
    [SerializeField] private GameObject collectEffect;
    [SerializeField] public int lifeImpact;
    [SerializeField] public int scoreImpact;

    public override bool ExecuteAction(GameObject other)
    {
        if (collectEffect != null)
        {
            //GameObject newObject = Instantiate<GameObject>(collectEffect);
            //newObject.transform.position = transform.position;
            GameObject newObject = Instantiate(collectEffect, transform.position, transform.rotation);
        }
        Destroy(gameObject);
        return base.ExecuteAction(other);
    }
}
