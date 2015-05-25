using UnityEngine;
using System.Collections;

public class HandleSonic : MonoBehaviour {

    public GameObject[] hits;
    private GameObject GOParticleSystem;
	// Use this for initialization
	void Start () {
        GOParticleSystem = transform.FindChild("ParticleSystem").gameObject;
        //InitSkill();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void InitSkill()
    {
        if (GOParticleSystem == null)
        {
            GOParticleSystem = transform.FindChild("ParticleSystem").gameObject;
        }
        GOParticleSystem.SetActive(true);
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        yield return new WaitForSeconds(1.20f);
        for (int i = 0; i < hits.Length; i++)
        {
            yield return new WaitForSeconds(0.75f);
            if (hits[i] != null)
            {
                hits[i].SetActive(true);
                Destroy(hits[i], 1.2f);
                hits[i] = null;
            }
        }
    }

    void HitColision(GameObject pe_GOColision)
    {
        Debug.Log("Colosiono con --> " + pe_GOColision.name);
    }
}
