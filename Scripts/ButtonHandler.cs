using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void SetText(string text) {
        Text txt = transform.Find("text").GetComponent<Text>();
        txt.text = text;
    }
}
