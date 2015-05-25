using UnityEngine;
using System.Collections;

public class SonicHitController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        SendMessageUpwards("HitColision",other.gameObject);
    }
}
