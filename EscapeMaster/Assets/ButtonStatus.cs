using UnityEngine;
using System.Collections;

public class ButtonStatus : MonoBehaviour {

    [SerializeField]
    private int _buttonID;
    public bool _isTrue = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Activate()
    {
        _isTrue = true;
    }
}
