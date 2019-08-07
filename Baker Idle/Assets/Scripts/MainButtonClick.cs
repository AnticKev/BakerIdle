using UnityEngine;
using System.Collections;

public class MainButtonClick : MonoBehaviour {

    public GameObject textbox;

    public void ClickTheButton ()
    {
        textbox.SetActive(true);
    }
	
}
