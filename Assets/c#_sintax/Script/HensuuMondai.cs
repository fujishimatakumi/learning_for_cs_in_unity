using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HensuuMondai : MonoBehaviour
{
    bool[] _result  = { false,false,false,false};
    Rensyuumonndai _mondai;
    void Start()
    {
        _mondai = FindObjectOfType<Rensyuumonndai>().GetComponent<Rensyuumonndai>();
        //練習問題ですTODOからENDTODOというコメントの間にコードを書いてください


        //問題①:numという名前の変数を定義して10という値を代入してください
        //TODO
        
        //ENDTODO

        //問題②:floatNumという名前の変数を定義して0.12という値を代入してください
        //TODO
        
        //ENDTODO

        //問題③:sNameという名前の変数を定義して[あいうえおaiueo]という値を代入してください
        //TODO
        
        //ENDTODO
        //問題④:flagという名前の変数を定義してtrueという値を代入してください
        //TODO
        
        //ENDTODO


        //問題の回答が全部終わったらこの下の行をコメントアウトしてね(//を消す)

        //CheckAnser(num, floatNum,sName, flag);

        _mondai.OnResultText(_result);

    }

    #region 解答
    //問題①：int num = 10;

    //問題②：float floatNum = 0.12f;

    //問題③:string sName = "あいうえおaiueo";

    //問題④:bool flag = true;

    #endregion

    private void CheckAnser(int num, float fnum, string name, bool flag)
    {
        if (num == 10)
        {
            _result[0] = true;
        }
        if (fnum.Equals(0.12f))
        {
            _result[1] = true;
        }
        if (name == "あいうえおaiueo")
        {
            _result[2] = true;
        }
        if (flag)
        {
            _result[3] = true;
        }
    }

}
