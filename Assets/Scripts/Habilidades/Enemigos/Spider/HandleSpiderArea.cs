using UnityEngine;
using System.Collections;

public class HandleSpiderArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void HitSpiderAreaColision(GameObject pe_GOColision)
    {
        Debug.Log(pe_GOColision.name);
    }
}
