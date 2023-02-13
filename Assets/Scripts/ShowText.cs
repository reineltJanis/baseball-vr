using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    [SerializeField]
    private float timeout = 2f;
    private TMP_Text hitText;

    void Start() {
        hitText = gameObject.GetComponent<TMP_Text>();
        hitText.enabled = false;
    }

    void Update(){
        if (timeout > 0)
        timeout -= Time.deltaTime;

        if (timeout <= 0 && hitText.enabled){
            hitText.enabled = false;
        }
    }

    public void SetText(string text) {
            timeout = 2f;
            hitText.enabled = true;
            hitText.SetText(text);
    }
}
