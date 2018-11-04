using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MultiGamePad;

public class GamepadDemo : MonoBehaviour {
   
    public GameObject[] button;
    public Slider[] Axis;
    public Slider select;
    public bool Mac=true;
    private int pad;
    public Text padt;
	// Use this for initialization
	
        private void Awake()
        {
            //OSX
            if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.tvOS)
            {
                GamePad.MacOS = true;
            }
            else
            {
                GamePad.MacOS = false;
            }
        }
    
	
	// Update is called once per frame
	void Update () {
        if (Mac == GamePad.MacOS)
        {
            button[0].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.Y, pad)));
            button[1].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.X, pad)));
            button[2].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.A, pad)));
            button[3].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.B, pad)));
            button[4].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.Back, pad)));
            button[5].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.L1, pad)));
            button[6].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.LeftStick, pad)));
            button[7].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.R1, pad)));
            button[8].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.RightStick, pad)));
            button[9].SetActive(Input.GetKey(GamePad.GetKey(GamePad.Button.Start, pad)));

            Axis[0].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.DpadAxisX, pad)) / 2 + 0.5f;
            Axis[1].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.DpadAxisY, pad)) / 2 + 0.5f;
            Axis[2].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.LeftStickAxisX, pad)) / 2 + 0.5f;
            Axis[3].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.LeftStickAxisY, pad)) / 2 + 0.5f;

            Axis[4].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.LeftTrigger, pad));
            Axis[5].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.RightTrigger, pad));

            Axis[6].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.RightStickAxisX, pad)) / 2 + 0.5f;
            Axis[7].value = Input.GetAxis(GamePad.GetAxis(GamePad.Axis.RightStickAxisY, pad)) / 2 + 0.5f;

        }





    }
    public void Padselect()
    {
        pad = (int)select.value;
        padt.text = pad.ToString();
    }

    public void Link()
    {
        Application.OpenURL("https://github.com/360Controller/360Controller/releases");
       

    }

}
