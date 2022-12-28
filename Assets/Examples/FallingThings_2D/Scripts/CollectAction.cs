using UnityEngine;

[AddComponentMenu("Playground/Actions/Collect Action")]
public class CollectAction : Action
{
    // assign an effect (explosion? particles?) or object to be created (instantiated) when the one gets destroyed
    [SerializeField] private GameObject collectEffect;
    public int lifeImpact;
    public int scoreImpact;
    [SerializeField] private AudioClip collectSound;
    private AudioSource player;

    private void Awake()
    {
        player = FindObjectOfType<HealthSystemAttribute>()?.GetComponent<AudioSource>();
    }

    public override bool ExecuteAction(GameObject other)
    {
        if (collectEffect != null)
        {
            Instantiate<GameObject>(collectEffect, transform.position, transform.rotation);
        }
        player.PlayOneShot(collectSound);
        Destroy(gameObject);
        return base.ExecuteAction(other);
    }
}
