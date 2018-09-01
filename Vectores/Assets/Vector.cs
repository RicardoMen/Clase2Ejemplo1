using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour {

	Transform direccion;
	Vector3 velocity = new Vector3 ( 0.2f,0.2f,0);
	Vector3 gravity = new Vector3 ( 0,-0.01f,0);


	// Use this for initialization
	void Start () {
		direccion = GetComponent<Transform> ();
	

	}
	
	// Update is called once per frame
	void Update () {

		velocity +=gravity;
		transform.position += velocity;

		if (transform.position.y < -3)
			
		{
			
			Vector3 aux = transform.position;
			aux.y = -3;
			transform.position = aux;
			velocity.y *= -1;


		}
		if (transform.position.x > 11) 
		{
			Vector3 aux = transform.position;
			aux.x = 11;
			transform.position = aux;
			velocity.x *= -1;
		}
		if (transform.position.x < -11) 
		{
			Vector3 aux = transform.position;
			aux.x = -11;
			transform.position = aux;
			velocity.x *= -1;
		}
		/*if (transform.position.y <= -3)
		{
			Vector3 aux = transform.position;
			aux.y = -3;
			transform.position = aux;
		}*/
		
	}
}
