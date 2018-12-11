using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyPlayer : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}
}
