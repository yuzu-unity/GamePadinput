using UnityEngine;
using System.Collections;

/*
 　 English

    How to use

    Driver required for Mac
    https://github.com/360Controller/360Controller/releases

    Expand the contents of the Inputmanager.zip
    Overwrite in the Projectsettings folder in the project folder
    In addition, unity does not start at this time! Crashes.
　　using Multigamepad; ← When you need to use


    Japanese

    OSXの場合
    https://github.com/360Controller/360Controller/releases
    ドライバが必要

    使い方
    InputManager.zipの中身を展開し
   
    projectフォルダ内のProjectSettingsフォルダ内に上書き
    なおこの時Unityは起動しないこと！
    クラッシュします。

    using MultiGamePad;←使用時必要

 */


//Fill the following somewhere (以下をどこかに記入)

/*

    private void Awake()
    {
    　　//OSX
        if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.tvOS)
        {
           GamePad.MscOS=true;
        }
        else
        {
           GamePad.MscOS=false;
        }
    }
*/


namespace MultiGamePad
{

    public static class GamePad 
    {
        public static bool MacOS = false;
    
        public enum Button { A ,B, Y, X, R1,L1, RightStick ,LeftStick,Back,Start }
        public enum Axis { DpadAxisX,DpadAxisY, LeftStickAxisX, LeftStickAxisY, RightStickAxisX , RightStickAxisY, LeftTrigger, RightTrigger }



        /*
            English

            Number is the type of gamepad
            0 Free 
            The following are for multiple use only
            1 GamePad 1
            2 GamePad 2
            3 GamePad 3 
            4 GamePad 4


            Japanese

            numberはゲームパッドの種類
            0 で自由

            以下は複数使用時のみ
            1 ゲームパッド1
            2 ゲームパッド2
            3 ゲームパッド3
            4 ゲームパッド4


         */


        // int Padnumber=0～4; 　 Input.GetAxis(GamePad.GetAxis(GamePad.Axis.DpadAxisX, Padnumber));
        // DpadAxisX DpadAxisY LeftStickAxisX LeftStickAxisY RightStickAxisX RightStickAxisY LeftTrigger RightTrigger

        public static string GetAxis(Axis axis,int number)
        {

            string Name = "";
            switch (axis)
            {
                case Axis.DpadAxisX:
                    if (!MacOS)
                    {
                        Name = "DPad_XAxis_" + number;
                    }
                    else
                    {
                        Name = "DPadMAC_XAxis_" + number;
                    }
                    break;
                case Axis.DpadAxisY:
                    if (!MacOS)
                    {
                        Name = "DPad_YAxis_" + number;
                    }
                    else
                    { 
                        Name = "DPadMAC_YAxis_" + number;
                    }
                    break;

                case Axis.LeftStickAxisX:
                    Name = "L_XAxis_" + number;
                    break;
                case Axis.LeftStickAxisY:
                    Name = "L_YAxis_" + number;
                    break;
                case Axis.RightStickAxisX:
                    if (!MacOS)
                    {
                        Name = "R_XAxis_" + number;
                    }
                    else
                    {
                        Name = "R_MACXAxis_" + number;
                    }
                    break;
                case Axis.RightStickAxisY:
                    if (!MacOS)
                    {
                        Name = "R_YAxis_" + number;
                    }
                    else
                    {
                        Name = "R_MACYAxis_" + number;
                    }
                    break;
                case Axis.LeftTrigger:
                    if (!MacOS)
                    {
                        Name = "TriggersL_" + number;
                    }
                    else
                    {
                        Name = "MACTriggersL_" + number;
                    }
                    break;
                case Axis.RightTrigger:
                    if (!MacOS)
                    {
                        Name = "TriggersR_" + number;
                    }
                    else
                    {
                        Name = "MACTriggersR_" + number;
                    }
                    break;
            }
            return Name;
        }

        // int number=0～4; Input.GetKeyDown(GamePad.GetKey(GamePad.Button.Y,Padnumber))
        // A B X Y R1 L1 Back Start LeftStick RightStick

        public static KeyCode GetKey(Button axis, int number)
        {
            switch (number)
            {
                case 1:
                    switch (axis)
                    {
                        case Button.A:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button0;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button16;
                            }
                        case Button.B:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button1;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button17;
                            }
                        case Button.X:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button2;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button18;
                            }
                        case Button.Y:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button3;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button19;
                            }
                        case Button.R1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button5;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button14;
                            }
                        case Button.L1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button4;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button13;
                            }
                        case Button.Back:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button6;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button10;
                            }
                        case Button.Start:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button7;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button9;
                            }
                        case Button.LeftStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button8;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button11;
                            }
                        case Button.RightStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick1Button9;
                            }
                            else
                            {
                                return KeyCode.Joystick1Button12;
                            }
                    }
                    break;
                case 2:
                    switch (axis)
                    {
                        case Button.A:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button0;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button16;
                            }
                        case Button.B:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button1;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button17;
                            }
                        case Button.X:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button2;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button18;
                            }
                        case Button.Y:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button3;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button19;
                            }
                        case Button.R1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button5;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button14;
                            }
                        case Button.L1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button4;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button13;
                            }
                        case Button.Back:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button6;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button10;
                            }
                        case Button.Start:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button7;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button9;
                            }
                        case Button.LeftStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button8;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button11;
                            }
                        case Button.RightStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick2Button9;
                            }
                            else
                            {
                                return KeyCode.Joystick2Button12;
                            }
                    }
                    break;
                case 3:
                    switch (axis)
                    {
                        case Button.A:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button0;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button16;
                            }
                        case Button.B:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button1;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button17;
                            }
                        case Button.X:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button2;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button18;
                            }
                        case Button.Y:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button3;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button19;
                            }
                        case Button.R1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button5;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button14;
                            }
                        case Button.L1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button4;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button13;
                            }
                        case Button.Back:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button6;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button10;
                            }
                        case Button.Start:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button7;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button9;
                            }
                        case Button.LeftStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button8;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button11;
                            }
                        case Button.RightStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick3Button9;
                            }
                            else
                            {
                                return KeyCode.Joystick3Button12;
                            }
                    }
                    break;
                case 4:

                    switch (axis)
                    {
                        case Button.A:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button0;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button16;
                            }
                        case Button.B:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button1;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button17;
                            }
                        case Button.X:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button2;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button18;
                            }
                        case Button.Y:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button3;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button19;
                            }
                        case Button.R1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button5;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button14;
                            }
                        case Button.L1:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button4;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button13;
                            }
                        case Button.Back:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button6;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button10;
                            }
                        case Button.Start:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button7;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button9;
                            }
                        case Button.LeftStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button8;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button11;
                            }
                        case Button.RightStick:
                            if (!MacOS)
                            {
                                return KeyCode.Joystick4Button9;
                            }
                            else
                            {
                                return KeyCode.Joystick4Button12;
                            }
                    }

                    break;
                case 0:
                    switch (axis)
                    {
                        case Button.A:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton0;
                            }
                            else
                            {
                                return KeyCode.JoystickButton16;
                            }
                        case Button.B:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton1;
                            }
                            else
                            {
                                return KeyCode.JoystickButton17;
                            }
                        case Button.X:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton2;
                            }
                            else
                            {
                                return KeyCode.JoystickButton18;
                            }
                        case Button.Y:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton3;
                            }
                            else
                            {
                                return KeyCode.JoystickButton19;
                            }
                        case Button.R1:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton5;
                            }
                            else
                            {
                                return KeyCode.JoystickButton14;
                            }
                        case Button.L1:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton4;
                            }
                            else
                            {
                                return KeyCode.JoystickButton13;
                            }
                        case Button.Back:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton6;
                            }
                            else
                            {
                                return KeyCode.JoystickButton10;
                            }
                        case Button.Start:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton7;
                            }
                            else
                            {
                                return KeyCode.JoystickButton9;
                            }
                        case Button.LeftStick:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton8;
                            }
                            else
                            {
                                return KeyCode.JoystickButton11;
                            }
                        case Button.RightStick:
                            if (!MacOS)
                            {
                                return KeyCode.JoystickButton9;
                            }
                            else
                            {
                                return KeyCode.JoystickButton12;
                            }
                    }
                    break;
            }
            return KeyCode.None;
        }

       

    }

   

}