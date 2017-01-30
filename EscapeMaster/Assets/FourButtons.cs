using UnityEngine;
using System.Collections;

public class FourButtons : MonoBehaviour {

    private KeyCode _key0;
    private KeyCode _key1;
    private KeyCode _key2;
    private KeyCode _key3;

    private bool[] _buttonsActive = new bool[4];

    [SerializeField]
    private float _permittedDelay;

    // Use this for initialization
    void Start () {
        _key0 = KeyCode.UpArrow;
        _key1 = KeyCode.DownArrow;
        _key2 = KeyCode.RightArrow;
        _key3 = KeyCode.LeftArrow;

        for (int i = 0; i < _buttonsActive.Length; i++)
        {
            _buttonsActive[i] = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(_key0))
        {
            ActivateButton(0);
        }

        if (Input.GetKeyDown(_key1))
        {
            ActivateButton(1);
        }

        if (Input.GetKeyDown(_key2))
        {
            ActivateButton(2);
        }

        if (Input.GetKeyDown(_key3))
        {
            ActivateButton(3);
        }
    }

    void ActivateButton(int ButtonID)
    {
        _buttonsActive[ButtonID] = true;
        TestButtonStatus();

    }

    void TestButtonStatus()
    {
        bool test = true;
        for (int i = 0; i < _buttonsActive.Length; i++)
        {
            if (_buttonsActive[i] == false)
            {
                test = false;
            }
        }

        if (test == true)
        {
            this.GetComponent<TestLocalPlayer>().UseMoveToPosition(0);
        }
    }

    IEnumerator DeActivateButton(int buttonID)
    {
        yield return new WaitForSeconds(_permittedDelay);
        _buttonsActive[buttonID] = false;
        yield return null;
    }
}
