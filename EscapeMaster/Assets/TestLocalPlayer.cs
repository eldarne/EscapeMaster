using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class TestLocalPlayer : NetworkBehaviour {

    private MoveMinion[] _minions = new MoveMinion[5];
    private bool[] _done = new bool[5];

    // Use this for initialization
    void Start () {
        _minions[0] = GameObject.FindGameObjectWithTag("1").GetComponent<MoveMinion>();
        _minions[1]= GameObject.FindGameObjectWithTag("2").GetComponent<MoveMinion>();
        _minions[2]= GameObject.FindGameObjectWithTag("3").GetComponent<MoveMinion>();
        _minions[3]= GameObject.FindGameObjectWithTag("4").GetComponent<MoveMinion>();
        _minions[4] = GameObject.FindGameObjectWithTag("5").GetComponent<MoveMinion>();

        for (int i = 0; i < _done.Length; i++)
        {
            _done[i] = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (_minions[0] == null)
        {
            _minions[0] = GameObject.FindGameObjectWithTag("1").GetComponent<MoveMinion>();
            _minions[1] = GameObject.FindGameObjectWithTag("2").GetComponent<MoveMinion>();
            _minions[2] = GameObject.FindGameObjectWithTag("3").GetComponent<MoveMinion>();
            _minions[3] = GameObject.FindGameObjectWithTag("4").GetComponent<MoveMinion>();
            _minions[4] = GameObject.FindGameObjectWithTag("5").GetComponent<MoveMinion>();
        }

	    if(!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CmdMoveToPosition(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CmdMoveToPosition(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CmdMoveToPosition(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CmdMoveToPosition(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CmdMoveToPosition(4);
        }
    }

    public void UseMoveToPosition(int minion)
    {
        if (!isLocalPlayer)
        {
            return;
        }
        CmdMoveToPosition(minion);
    }


    [Command]
    void CmdMoveToPosition(int minion)
    {
        if (_done[minion] == true)
        {
            return;
        }
        Vector3 newPosition = new Vector3(_minions[minion].transform.position.x, _minions[minion].transform.position.y, _minions[minion].transform.position.z + 2.5f);
        _minions[minion].transform.position = newPosition;
        _done[minion] = true;
    }
}
