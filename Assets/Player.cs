using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    List<GameObject> voxelsInRange = new List<GameObject>();
    public GameObject IndicatorVoxel;

	// Update is called once per frame
	void Update () {
	
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject g in voxelsInRange)
            {
                if (g.tag == "Voxel")
                {
                    g.SendMessage("Loose", IndicatorVoxel.transform.position);
                }
            }
        }

	}

    void OnTriggerEnter(Collider col)
    {
        voxelsInRange.Add(col.gameObject);
    }

    void OnTriggerExit(Collider col)
    {
        voxelsInRange.Remove(col.gameObject);
    }
}
