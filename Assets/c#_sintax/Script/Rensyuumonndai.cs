using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rensyuumonndai : MonoBehaviour
{
    [SerializeField] Text[] _texts;
    [SerializeField] Color _seikaiColor;
    [SerializeField] Color _huseikaiColor;

    private void Awake()
    {
        foreach (Text text in _texts)
        {
            text.text = "";
        }
    }


    public void OnResultText(bool[] results)
    {
        Debug.Log(_texts.Length + " " + results.Length);
        if (_texts.Length != results.Length) return;

        Debug.Log("s");
        for (int i = 0; i < results.Length; i++)
        {
            if (results[i])
            {
                _texts[i].text = $"{i + 1}問目：正解！";
                Debug.Log(_texts[i].text);
                _texts[i].color = _seikaiColor;
            }
            else
            {
                _texts[i].text = $"{i + 1}問目：不正解";
                _texts[i].color = _huseikaiColor;
            }
        }
    }
}
