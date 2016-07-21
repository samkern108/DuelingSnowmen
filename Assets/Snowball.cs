using UnityEngine;
using System.Collections;

public class Snowball : MonoBehaviour {

	private Rigidbody2D rb;

	public void Start()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionStay2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Child") {
			Debug.Log (rb.velocity.magnitude);
			if (rb.velocity.magnitude > 0) {
				float sizeInc = rb.velocity.magnitude / 2;
				transform.localScale += new Vector3 (sizeInc, sizeInc, 0);
			}
		}
	}
}
