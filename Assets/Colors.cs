using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Colors : MonoBehaviour
{
    public TextMeshProUGUI text;
    public RawImage backround;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Dawg());
        Debug.Log("Start");
    }

    IEnumerator Dawg()
    {
        while (1 == 1)
        {
            Debug.Log("Call");
            text.color = Color.red;
            backround.color = Color.black;
            yield return new WaitForSeconds(.005f);
            text.color = Color.yellow;
            backround.color = Color.red;
            yield return new WaitForSeconds(.005f);
            text.color = Color.black;
            backround.color = Color.yellow;
            yield return new WaitForSeconds(.005f);
        }

    }
}
