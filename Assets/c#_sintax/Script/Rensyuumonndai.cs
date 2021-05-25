using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rensyuumonndai : MonoBehaviour
{
    [SerializeField] Text[] _texts;
    [SerializeField] Color _seikaiColor;
    [SerializeField] Color _huseikaiColor;
    private void Start()
    {
        foreach (Text text in _texts)
        {
            text.text = "";
        }
    }


    public void OnResultText(bool[] results)
    {
        if (_texts.Length != results.Length) return;
        
        for (int i = 0; i < results.Length; i++)
        {
            if (results[i])
            {
                _texts[i].text = $"{i + 1}問目：正解！";
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
