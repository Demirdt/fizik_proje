using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Windows;

public class keypad_controller : MonoBehaviour
{

    public GameObject speed_input_x_object, speed_input_y_object, gravity_input_object;
    TMP_InputField speed_input_x, speed_input_y, gravity_input;

    // with angle
    public GameObject main_speed_input_object, angle_input_object;  // no i wont fix these names
    TMP_InputField main_speed_inputfield, angle_inputfield;
    
    Input_mode mode = Input_mode.InputX;
    bool toggle = false;
    public GameObject keys, image;

    void Start()
    {
        speed_input_x = speed_input_x_object.GetComponent<TMP_InputField>();
        speed_input_y = speed_input_y_object.GetComponent<TMP_InputField>();
        gravity_input = gravity_input_object.GetComponent<TMP_InputField>();
        main_speed_inputfield = main_speed_input_object.GetComponent<TMP_InputField>();
        angle_inputfield = angle_input_object.GetComponent<TMP_InputField>();
    }


    public void Switch()
    {
        if (toggle)
        {
            toggle = false;
            image.SetActive(false);
            keys.SetActive(false);
        }else
        {
            toggle = true;
            image.SetActive(true);
            keys.SetActive(true);
        }
    }

    public void Delete()
    {
        switch (mode)
        {
            // This is awful
            case Input_mode.InputX:
                speed_input_x.text = speed_input_x.text.Remove(speed_input_x.text.Length - 1);
                break;
            case Input_mode.InputY:
                speed_input_y.text = speed_input_y.text.Remove(speed_input_y.text.Length - 1);
                break;
            case Input_mode.Gravity:
                gravity_input.text = gravity_input.text.Remove(gravity_input.text.Length - 1);
                break;
            case Input_mode.MainSpeed:
                main_speed_inputfield.text = main_speed_inputfield.text.Remove(main_speed_inputfield.text.Length - 1);
                break;
            case Input_mode.Angle:
                angle_inputfield.text = angle_inputfield.text.Remove(angle_inputfield.text.Length - 1);
                break;
        }
    }
    void InputValue(char input)
    {
        switch (mode)
        {
            case Input_mode.InputX:
                speed_input_x.text += input;
                break;
            case Input_mode.InputY:
                speed_input_y.text += input;
                break;
            case Input_mode.Gravity:
                gravity_input.text += input;
                break;
            case Input_mode.MainSpeed:
                main_speed_inputfield.text += input;
                break;
            case Input_mode.Angle:
                angle_inputfield.text += input;
                break;
        }

    }

    public void Select_InputX()
    {
        mode = Input_mode.InputX;
    }
    public void Select_InputY()
    {
        mode = Input_mode.InputY;
    }
    public void Select_GravityInput()
    {
        mode = Input_mode.Gravity;
    }
    public void Select_MainSpeed()
    {
        mode = Input_mode.MainSpeed;
    }
    public void Select_Angle()
    {
        mode = Input_mode.Angle;
    }
    public void Input_Negative()
    {
        InputValue('-');
    }
    public void Input_Zero()
    {
        InputValue('0');
    }
    public void Input_One()
    {
        InputValue('1');
    }
    public void Input_Two()
    {
        InputValue('2');
    }
    public void Input_Three()
    {
        InputValue('3');
    }
    public void Input_Four()
    {
        InputValue('4');
    }
    public void Input_Five()
    {
        InputValue('5');
    }
    public void Input_Six()
    {
        InputValue('6');
    }
    public void Input_Seven()
    {
        InputValue('7');
    }
    public void Input_Eight()
    {
        InputValue('8');
    }
    public void Input_Nine()
    {
        InputValue('9');
    }
    public void Input_Dot()
    {
        InputValue('.');
    }
    enum Input_mode
    {
        InputX,
        InputY,
        Gravity,
        Angle,
        MainSpeed,
    }

}
