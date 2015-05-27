using UnityEngine;
using System.Collections;

public class HandleRatExplosion : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
    }

}
