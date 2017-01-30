using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MoveMinion : NetworkBehaviour {

    [SerializeField]
    private Transform[] _wayPoints;
    [SerializeField]
    private int ID;

	// Use this for initialization
	/*void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }

	    if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (ID == 0)
            {
                CmdMoveToPosition();
                Debug.Log("Hellow World");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (ID == 1)
            {
                CmdMoveToPosition();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (ID == 2)
            {
                CmdMoveToPosition();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (ID == 3)
            {
                CmdMoveToPosition();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (ID == 4)
            {
                CmdMoveToPosition();
            }
        }
    }

    public void StartMoveToPosition()
    {
        CmdMoveToPosition();
    }

    [Command]
    void CmdMoveToPosition()
    {
        Vector3 newPosition = new Vector3(this.transform.position.x, this.transform.position.y, _wayPoints[ID].position.z - 0.5f);
        this.transform.position = newPosition;
    }*/
}
