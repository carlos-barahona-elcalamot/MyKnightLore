using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SunMoonTMP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSunrise() {
        Debug.Log("TextMeshPro sunrise event");
        GetComponent<TextMeshProUGUI>().SetText("Day");
    }

    public void OnMoonrise() {
        Debug.Log("TextMeshPro moonrise event");
        GetComponent<TextMeshProUGUI>().SetText("Night");
    }
}
