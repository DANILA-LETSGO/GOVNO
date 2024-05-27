using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OMNOM : MonoBehaviour {

	// это переменная жопа, хрен, лох, тапочек.
	int jopa;
	int xren = 88;
	int fuck = 0;

	bool red = false;

	string lox;

	float tapochek = 99.9f;

	// позиция в координатах x y z. 
	Vector3 koks = new Vector3 (1,8,5); 


	void Start () {
		jopa = 3;
		jopa = 8;
		xren = jopa + 5;
		lox = "пидр";
		koks = new Vector3 (jopa, xren, 1);
		transform.position = new Vector3 (1,1,1);

		if (8 == 8) {
			print ("верно");
		}

		print (koks);
		print (lox);
		print (tapochek / 9);
		print (xren);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = transform.position + new Vector3 (-0.6f, 0, 0.1f);
		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + new Vector3 (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + new Vector3 (0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.1f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.1f);
		}

		// Прыжок
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (transform.position.y < 0.1f) {
				red = true;
			}
		}

		if (red == true) {
			transform.position = transform.position + new Vector3 (0, 0.8f, 0);
			fuck = fuck + 1;
			if (fuck == 10) {
				red = false;
				fuck = 0;
			}
		}
		if (red == false) {
			if (transform.position.y > 0) {
				transform.position = transform.position + new Vector3 (0, -0.1f, 0);
			}
		}
		// закончили прыжок...
			

		
	}
}
