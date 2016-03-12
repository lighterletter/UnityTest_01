using UnityEngine;
using System.Collections;

public class movecube : MonoBehaviour {

	public float direction;
	public float horizontal;
	public float vertical;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis ("Horizontal");
		vertical = Input.GetAxis ("Vertical");

		//transform.position += direction;
	}
}
