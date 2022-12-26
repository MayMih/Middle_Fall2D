using UnityEngine;

using static UnityEngine.GraphicsBuffer;

[AddComponentMenu("Playground/Actions/Collect Action")]
public class CollectAction : Action
{
    // assign an effect (explosion? particles?) or object to be created (instantiated) when the one gets destroyed
    public GameObject collectEffect;

    public override bool ExecuteAction(GameObject other)
    {
        if (collectEffect != null)
        {
            GameObject newObject = Instantiate<GameObject>(collectEffect);
            newObject.transform.position = transform.position;
        }
        Destroy(gameObject);
        return base.ExecuteAction(other);
    }
}
