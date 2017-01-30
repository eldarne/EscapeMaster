using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class TestCollision : NetworkBehaviour {

    [SerializeField]
    private Material[] _materials;
    [SerializeField]
    private int ID;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (isLocalPlayer)
        {
            
        }
        else
        {
            return;
        }
	}

    void OnTriggerEnter()
    {
        this.GetComponent<Renderer>().material = _materials[ID];
    }
}
