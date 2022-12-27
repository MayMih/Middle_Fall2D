using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Object Creator Area")]
[RequireComponent(typeof(BoxCollider2D))]
public class ObjectCreatorArea : MonoBehaviour
{
	[Header("Object creation")]

	// The object to spawn
	// WARNING: take if from the Project panel, NOT the Scene/Hierarchy!
	public GameObject prefabToSpawn;

	[Header("Other options")]

	// Configure the spawning pattern
	public float spawnInterval = 1;

	private BoxCollider2D boxCollider2D;

	private float partOfSpawnAreaWidth;

	void Start ()
	{
		boxCollider2D = GetComponent<BoxCollider2D>();
        partOfSpawnAreaWidth = boxCollider2D.size.x / 3;
        StartCoroutine(SpawnObject());
	}
	
	// This will spawn an object, and then wait some time, then spawn another...
	IEnumerator SpawnObject ()
	{
		while(true)
		{
			// Create some random numbers
			//float randomX = Random.Range(-boxCollider2D.size.x, boxCollider2D.size.x);// *.5f;
			//float randomY = Random.Range(-boxCollider2D.size.y, boxCollider2D.size.y);// *.5f;

			// Generate the new object
			GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
            //newObject.transform.position = new Vector2(randomX + transform.position.x - tenPercentOfSpawnAreaWidth, 
            //	 randomY + transform.position.y);
            float randomX = transform.position.x + Random.Range(partOfSpawnAreaWidth - boxCollider2D.size.x, 
				  boxCollider2D.size.x - partOfSpawnAreaWidth);
            float randomY = Random.Range(-boxCollider2D.size.y, boxCollider2D.size.y);
            //        newObject.transform.position = new Vector2(Mathf.Min(transform.position.x + boxCollider2D.size.x - 
            //partOfSpawnAreaWidth, Mathf.Max(transform.position.x + partOfSpawnAreaWidth, randomX)),
            //             randomY + transform.position.y);
            newObject.transform.position = new Vector2(randomX,randomY + transform.position.y);
            // Wait for some time before spawning another object
            yield return new WaitForSeconds(spawnInterval);
		}
	}
}
