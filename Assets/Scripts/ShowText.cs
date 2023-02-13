using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    [SerializeField]
    private float timeout = 2f;
    private TMP_Text homeRunText;

    void Start() {
        homeRunText = GameObject.Find("HomeRunText").GetComponent<TMP_Text>();
        homeRunText.enabled = false;
    }

    void Update(){
        if (timeout > 0)
        timeout -= Time.deltaTime;

        if (timeout <= 0 && homeRunText.enabled){
            homeRunText.enabled = false;
        }
    }

    public void SetText(string text) {
            timeout = 2f;
            homeRunText.enabled = true;
            homeRunText.SetText(text);
    }
}
