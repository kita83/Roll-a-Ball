using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DangerWall : MonoBehaviour {

	void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.CompareTag("Player")) {
			int sceneIndex = SceneManager.GetActiveScene ().buildIndex;

			SceneManager.LoadScene (sceneIndex);
		}
	}
}
