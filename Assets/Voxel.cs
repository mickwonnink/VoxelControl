using UnityEngine;
using System.Collections;

public class Voxel : MonoBehaviour {

    bool isLoose = false;
    float strength = 100;

    Rigidbody thisRb;

	// Use this for initialization
	void Start () {
        thisRb = GetComponent<Rigidbody>();
	}

    public void Loose(Vector3 indiPos)
    {
        thisRb.isKinematic = false;
        thisRb.AddForce((indiPos - transform.position).normalized * strength);
    }
}
