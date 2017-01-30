using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Identifier : NetworkBehaviour {

    [SerializeField]
    public int _identifier = -1;
    [SerializeField]
    private Camera[] _cameras;
    [SerializeField]
    private ButtonStatus[] _buttonStatus;
    [SerializeField]
    public GameObject _canvas;
    private bool _identified = false;



    //0 : PC Projecteur 1 - 1 : PC Projecteur 2 - 2 : PC Feedback - 3 : Tablette Feedback - 4 : PC 4 Buttons - 5 : Tablette 4 Codes

    void Start()
    {

    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0;i<players.Length;i++)
        {
            if (players[i] == this.gameObject)
            {

            }
            else
            {
                players[i].GetComponent<Identifier>()._canvas.SetActive(false);
            }
        }
        if (_identified == false)
        {
            if (_buttonStatus[0]._isTrue == true)
            {
                _identifier = 0;
                Identify(0);
            }
            if (_buttonStatus[1]._isTrue == true)
            {
                _identifier = 1;
                Identify(1);
            }
            if (_buttonStatus[2]._isTrue == true)
            {
                _identifier = 2;
                Identify(2);
            }
            if (_buttonStatus[3]._isTrue == true)
            {
                _identifier = 3;
                Identify(3);
            }
            if (_buttonStatus[4]._isTrue == true)
            {
                _identifier = 4;
                Identify(4);
            }
            if (_buttonStatus[5]._isTrue == true)
            {
                _identifier = 5;
                Identify(5);
            }
        }
    }

    public void Identify(int identifier)
    {
        _identified = true;
        _identifier = identifier;
        SetCamera();
    }

    private void SetCamera()
    {
        _cameras[_identifier].gameObject.SetActive(true);
        _canvas.SetActive(false);
    }
}
