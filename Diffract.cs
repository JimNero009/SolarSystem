using UnityEngine;
using System.Collections;

public class Diffract : MonoBehaviour { // Destroy the object entering the collider and create two new objects after it

	public GameObject createObject; // Object that is created
	public Vector3 instantiateTransform1; // Where to place new object 1
	public Vector3 instantiateTransform2; // Where to place new object 2
	
	void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag == "Puzzle_Sphere") { // If a puzzle sphere is colliding 
			Destroy(other.gameObject); // Destory object that collided i.e. the puzzle sphere
			// Create 2 new objects behind the collider as specified by public variables 
			Instantiate (createObject, transform.position + instantiateTransform1, Quaternion.identity);
			Instantiate (createObject, transform.position + instantiateTransform2, Quaternion.identity);
		}
	}
}
