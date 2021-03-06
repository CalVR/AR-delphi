using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleRotateDrag : MonoBehaviour {

    //public bool iAmDrag;

    //public Text dragText;
    //public Text rotateText;
    public BarChartBuilder bcb;


    public ButtonState buttonsState;

    void Toggle(GameObject currentObj) {
        if (currentObj.name == "Drag")
        {
            //dragText.text = "On";
            //rotateText.text = "Off";
            Gesture.Instance.GestureTransitionOuterControl(1);
            buttonsState.SwitchButtonState();
        }

        else if (currentObj.name == "Rotate")
        {
            //rotateText.text = "On";
            //dragText.text = "Off";
            // call rotate
            Gesture.Instance.GestureTransitionOuterControl(0);
            buttonsState.SwitchButtonState();
        }

        else if (currentObj.name == "Next")
        {
            bcb.AdjustZipCode(1);
            buttonsState.SetText("Zipcode: "+bcb.currentZipCode+"");


        }

        else
        {
            Debug.Log("How come nothing happen!!");
        }
    }
}
