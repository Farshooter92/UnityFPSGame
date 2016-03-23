using UnityEngine;
using System.Collections;

public class ColliderDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hit");
        
        foreach (ContactPoint contact in col.contacts)
        {
            Debug.Log(contact.thisCollider.name + " hit " + contact.otherCollider.name);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        Debug.Log(other.name);
    }
}
