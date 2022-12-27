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

	private UIScript ui;

	[Header("Other options")]

	// Configure the spawning pattern
	public float spawnInterval = 1;

	private BoxCollider2D boxCollider2D;

	private float partOfSpawnAreaWidth, minX, maxX;

	void Start ()
	{
        ui = GameObject.FindObjectOfType<UIScript>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        partOfSpawnAreaWidth = boxCollider2D.size.x / 3;
		minX = partOfSpawnAreaWidth - boxCollider2D.size.x;
		maxX = boxCollider2D.size.x - partOfSpawnAreaWidth;
        StartCoroutine(SpawnObject());
	}
	
	// This will spawn an object, and then wait some time, then spawn another...
	IEnumerator SpawnObject()
	{
		while(true)
		{
			if (!ui?.IsGameOver ?? true)
			{
				// Generate the new object
				GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
				float randomX = transform.position.x + Random.Range(minX, maxX);
				float randomY = Random.Range(-boxCollider2D.size.y, boxCollider2D.size.y);
				newObject.transform.position = new Vector2(randomX, randomY + transform.position.y);
			}
            // Wait for some time before spawning another object
            yield return new WaitForSeconds(spawnInterval);
		}
	}
}
