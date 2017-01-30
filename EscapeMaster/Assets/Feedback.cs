    using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Feedback : NetworkBehaviour {

    [SerializeField]
    private GameObject[] _backgrounds;
    [SerializeField]
    private Transform _backgroundAnchor;
    [SerializeField]
    private Transform _backgroundAnchorHide;
    [SerializeField]
    private int[] _code;
    [SerializeField]
    private InputField _inputField;
    [SerializeField]
    private Transform _anchorInputField;

    private Identifier _identifier;
    private bool _inputFieldMoved = false;


    // Use this for initialization
    void Start () {
        _identifier = this.GetComponent<Identifier>();
	}
	
	// Update is called once per frame
	void Update () {
        if (_inputFieldMoved == false && _identifier._identifier == 2)
        {
            _inputField.transform.position = _anchorInputField.position;
            _inputFieldMoved = true;
        }
        if (!isLocalPlayer || _identifier._identifier != 2)
        {
            Debug.Log(_identifier._identifier);
            return;
        }
	    if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            CmdTestCode(0,_inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            CmdTestCode(1, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            CmdTestCode(2, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            CmdTestCode(3, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            CmdTestCode(4, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            CmdTestCode(5, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            CmdTestCode(6, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            CmdTestCode(7, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            CmdTestCode(8, _inputField.text);
        }

        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            CmdTestCode(9, _inputField.text);
        }
    }

    [Command]
    void CmdTestCode(int input, string text)
    {
        _inputField.text = text;
        for (int i = 0; i < _backgrounds.Length; i++)
        {
            _backgrounds[i].transform.position = _backgroundAnchorHide.transform.position;
        }
        if (_inputField.text.Length > _code.Length)
        {
            _backgrounds[1].transform.position = _backgroundAnchor.transform.position;
            return;
        }
        Debug.Log(_inputField.text.Length);
        if (input == _code[_inputField.text.Length -1])
        {
            _backgrounds[0].transform.position = _backgroundAnchor.transform.position;
            return;
        }

        bool _isInTheCode = false;
        for (int i = 0; i < _code.Length; i++)
        {
            if (_code[i] == input)
            {
                _backgrounds[2].transform.position = _backgroundAnchor.transform.position;
                _isInTheCode = true;
            }
        }

        if (_isInTheCode == false)
        {
            _backgrounds[1].transform.position = _backgroundAnchor.transform.position;
        }
    }
}
