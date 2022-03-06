using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLowHPScreen : MonoBehaviour
{
        public GameObject lowHealthScreen;

    public void enableScreen() {
        lowHealthScreen.SetActive(true);
    }
    public void disableScreen() {
        lowHealthScreen.SetActive(false);
    }
}
