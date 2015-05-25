using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    public GameObject target;
    private string prefab;
    private Transform posicionTrower;
	// Use this for initialization
	void Start () {
        prefab = "Habilidad/Enemigos/Bat/BatSonic";

        posicionTrower = transform.FindChild("SkillThrower");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject w_batSonic = Resources.Load(prefab,typeof(GameObject)) as GameObject;

            GameObject w_batSonicInstantiate = Instantiate(w_batSonic, posicionTrower.position, Quaternion.identity) as GameObject;

            Vector3 target_position = new Vector3(target.transform.position.x,
                                                  transform.position.y,
                                                  target.transform.position.z);

            w_batSonicInstantiate.name = "BatSonicSkill";
            //w_batSonicInstantiate.transform.LookAt(target_position);
            w_batSonicInstantiate.GetComponent<HandleSonic>().InitSkill();

            Destroy(w_batSonicInstantiate, 5.0f);
        }
	}
}
