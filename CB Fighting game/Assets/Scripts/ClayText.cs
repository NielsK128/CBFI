using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClayText : MonoBehaviour
{
    public TMP_Text clayText;

    void Update()
    {
        clayText.text = "Clay: " + GlobalClay.getClay().ToString();
    }
}
