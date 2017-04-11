using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
		AsteroidData loadAD = new AsteroidData("Asteroid.txt");
		print(loadAD.position);

//		for (int i = 0; i < 4; i++) {
//			GameObject sphere = Instantiate (Resources.Load ("Prefabs/Sphere") as GameObject);
//			sphere.transform.position = loadAD [i];
//
//		}
	}

	// Update is called once per frame
	void Update () {

	}
}
