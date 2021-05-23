﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kisokoubunn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        /*　プログラミングの基礎について
         *
         *　プログラミングにおいて知っておかなければならないこと
         *　
         *　・プログラムは変数(データ)と関数(機能)で構成されています
         *　　→コンピュータプログラムは一見複雑に見えますが実際は変数と関数の組み合わせでできています
         *　　言い換えると変数と関数を理解すればプログラミングを理解することができるといっても良い
         *　　
         *　・プログラミング言語はコンピュータに命令するための言葉
         *　　→プログラミング言語はコンピュータに命令を与える言語です
         *　　  コンピュータは命令されたことを素直に実行します
         *　　  プログラムが思った通りに動かないのは命令を間違えて伝えています
         *　　  
         *　・エラーは友達怖くない
         *　  →コンピュータは命令を忠実に実行するのはわかったと思います
         *　  　ですのでコンピュータは理解できない事は素直に理解できないと教えてくれます
         *　  　それがエラーです。
         *　  　エラーを見ればプログラムのどこが間違ているのかがわかります
         *　  　なのでエラーが出た場合はエラーをよく読みましょう
         *　　
         *　・プログラムは上から順に実行される
         *　　→プログラムは基本的に上の行(または文)から順に実行されます。
         *　　　そして一行ごとに処理を実行しています。
         *　　　この一行とは基本的に；(セミコロンと読む)で区切られます
         *　　　つまり一行(文)の最後には；が付きます
         *　　　例）
         *　　　 int i = 0; ←これで一文
         *　　　 
         *　　　 int i2 = 0;←これで一文
         *　　　
         *　　
         *　　
         *　・プログラミングで扱う値は変数に代入(=)して保存しておかないと扱えない
         *　  プログラミングでは値は変数に代入しないと消えてしまいます
         *　  消えるタイミングは行が更新されたタイミングだと考えておけばよいです
         *　  例）
         *　     int x = 3;
         *　     int y = 2;
         *　     x + y；←この行ではxとyを足した値を扱えるが
         *　     Debug.Log();←次の行では値を使うことができない
         *　     
         *　  
         *　
         *　・変数には型（種類）があり型が一致しないと代入することができない
         *　  変数には型（種類）があり型（種類）が一致しないと代入することができない（値を保存しておくことができない）
         *    つまりｃ＃では型を意識する必要があるがよく使う型（int,float,string,bool）を覚えておけば良いです；
         *    
         *    例）
         *    　int i = 1; ←intは整数型で1も整数型なので代入可能
         *      int i2 = "abc"←intは整数型だが"abc"はstring型なので代入不可能
         *      string s = 1;←上と逆でも型が一致していないので代入不可能
         */

        /*
        //プログラミングで値を自由に使いたい場合,代入演算子を使って変数に値を代入する必要がある
        //　左辺　＝　右辺　←　この場合左辺に右辺の値を代入するといえる
        //　例）
            int i = 1;←左辺のint型の変数iに右辺の1という値を代入
            int n = i;←左辺のint型の変数nに右辺の変数iの値
        ※ちなみに変数を新たに作ることを変数を「定義する」といいます

        プログラミングの基本的な考え方と操作になるので覚えるようにしましょう

        以下では最低限覚えておく型について説明します
        */
        //変数は 型名 変数名；という構文で定義します
        //変数を定義する場合の変数名はなんでも大丈夫です
        //ただし、プログラミング上に同じ名前の変数は使えないです

        //例　いかでint型の変数名がnumという変数を定義してみます

      //↓型名　↓変数名

        int 　　num; 

        int i = 1; //整数型　１,２や-1、-2といった整数の値を扱う型

        Debug.Log(i);//unityでconsoleウィンドウに値を表示する関数
                    //今はConsole.WriteLine()と同じものと考えてよい

        float f = 1.2f;//少数型 1.2や3.4などの少数の値を扱う型


        double d = 1.23;//少数型　float型より扱える小数点以下の数が多い

        bool flag = true; //真か偽を扱う型　条件判定等で使う型　trueかfalseの二種類のみでtrueが真、falseが偽となる


        char a = 'a';//文字型 文字を扱う方char型は一文字だけ扱える
                     //ｃ＃では'(シングルクォーテーションと読む)の記号で囲んだものは文字として扱われる

        string s = "abc";//文字列型　文字列を扱う型　文字列とは文字(char型)を集めたもの
                        //c＃では"(ダブルクオーテーションと読む)の記号で囲んだものは文字列として扱われる
        Debug.Log(s);


        int i2 = 1 + 20;//3 +:加算演算子　足し算
        Debug.Log(i2);
        
        

        i2 = 1 - 2; //-1　-:減算演算子　引き算
        i2 = 1 * 2; //2   *:乗算演算子　掛け算
        i2 = 1 / 2; //0   /:除算演算子　割り算
        i2 = 1 % 2; //1   %:剰余演算子　余りを求める　左では1÷2　の余りである1を結果として返す

        Debug.Log(i2);

        int x = 1; 
        int y = 2;

        int z = x + y;//変数同士の足し算　以下同様
        z = x - y;　//変数の値を変えると計算結果も変わる
        z = x * y;
        z = x / y;

        Debug.Log(z);


        //以下基本構文
        //条件分岐構文
        /*
         * 
         * 条件文で使用する比較演算子
         * 
         *・< 　→ 左辺の値が右辺の値より小さい場合trueとなる。それ以外はfalseとなる。記号の読み方はしょうなりと読む
         *  例）
         *      10 < 20  ←trueとなる
         *      20 < 10　←falseとなる
         *・>　 →左辺の値が右辺の値より大きい場合trueとなる。それ以外はfalseとなる。記号の読み方はだいなりと読む
         *  例）
         *     20 > 10 ←trueとなる
         *     10 > 20 ←falseとなる
         *・<=  →左辺の値が右辺の値以下である場合trueとなる。それ以外はfalseとなる。記号の読み方はしょうなりイコール（一説）と読む
         *  例）
         *     10 <= 20 ←trueとなる 
         *     10 <= 10 ←trueとなる
         *     20 <= 10 ←falseとなる
         *
         *・>=　→　左辺の値が右辺の値以上である場合trueとなる。それ以外はfalseとなる。記号の読み方はだいなりイコール（一説）と読む
         *  例）
         *     20 >= 10 ←trueとなる
         *     20 >= 20 ←trueとなる
         *     10 >= 20 ←falseとなる
         *・==　→　左辺の値と右辺の値が同じである場合trueとなる。それ以外falseとなる。読み方はイコールイコールまたはダブルイコール
         *  例）
         *     10 == 10 ←true
         *     "aaa" == "aaa" ←true
         *     10 == 20 ←false
         *     "ab" == "cd" ←false
         *     
         *    以下は論理演算子と呼ばれる演算子で条件式と条件式の比較に使用する
         *    
         *・&&  → 左辺の条件式と右辺の条件式がtrueの場合trueとなる。どちらかの条件式がfalseの場合はfalseとなる読み方はかつと読む
         *　例）true       true
         *　   10 < 20 && 30 < 40 ←trueとなる
         *　   
         *　    false      true
         *　   20 < 10 && 30 < 40 ←falseとなる
         *　   
         *　    true       false
         *　   10 < 20 && 40 < 30 ←falseとなる
         *　   
         *　   　false     false
         *　   20 < 10 && 40 < 30 ←falseとなる
         *・||　→左辺の条件式か右辺の条件式のどちらかがtrueの場合trueとなる。両方の条件式がfalseの場合はfalseとなる読み方はまたはと読まれる
         *  例）
         *       true       true
         *      10 < 20 || 30 < 40 ←trueとなる
         *      
         *       false      true
         *      20 < 10 || 30 < 40 ←trueとなる
         *      
         *       true       false
         *      10 < 20 || 40 < 30 ←trueとなる
         *      
         *       false      false
         *      20 < 10 || 40 < 30 ←falseとなる
         *      
         *      
         *      条件分岐構文では上記の比較演算子と論理演算子を多用するので自由に扱えるように
         *  　　なるまで学習するようにしましょう
         * 
         *  if文
         * 
         *  if(条件文)
         *  {
         *      条件文がtrueだった場合にここの処理が実行される
         *      条件文がfalseだった場合にはここの処理は実行されずにプログラムが下に流れていく
         *  }
         *
         *  if/else文
         *  
         *  if(条件文)
         *  {
         *      条件文がtrueだった場合にここの処理が実行される
         *      条件文がfalseだった場合にはここの処理は実行されずにプログラムが下に流れていく
         *  }
         *  else
         *  {
         *      どのif文,ifelse文の条件にも当てはまらなかった場合にここの処理が実行される
         *  }
         *  
         *  if/ifelse/else文
         *  
         *  if(条件文)
         *  {
         *      条件文がtrueだった場合にここの処理が実行される
         *      条件文がfalseだった場合にはここの処理は実行されずにプログラムが下に流れていく
         *  }
         *  else if(条件文)
         *  {
         *      ブロック直前の条件文がtrueだった場合にここの処理が実行される
         *      条件文がfalseだった場合にはここの処理は実行されずにプログラムが下に流れていく
         *  }
         *  else
         *  {
         *      どのif文,ifelse文の条件にも当てはまらなかった場合にここの処理が実行される
         *  }
         *  
         *
         */
        //if文・ifelse文・else文

        int hoge = 1;

        if (hoge == 1)
        {
            Debug.Log("処理に入ってきた");
        }

        if (hoge == 0)
        {
            Debug.Log("hogeが0の場合に処理に入る");
        }
        else if (hoge == 1)
        {
            Debug.Log("hogeが１の場合処理に入る");
        }

        if (hoge == 0)
        {
            Debug.Log("hogeが０の場合処理に入る");
        }
        else
        {
            Debug.Log("if分の条件ではない場合に入る処理：この場合はhogeが０以外の場合");
        }


        //swithc文
        int jyoukenn = 2;
        switch (jyoukenn)
        {
            case 0:
                Debug.Log("jyoukennが０の場合に処理に入る");
                break;
            case 1:
                Debug.Log("jyoukennが1の場合に処理に入る");
                break;
            case 2:
                Debug.Log("jyoukennが2の場合に処理に入る");//今回はjyoukennの値が２なのでこの処理に入る
                break;
        }

        //繰り返し処理 while文 for文
        /*
         *   コンピュータプログラミングの中で一番特徴的で一番便利である機能である繰り返し構文
         *   
         *   コンピュータプログラミングで使われないことはないといっても良い構文なので
         *   しっかりとマスターしましょう。
         *   繰り返し構文では上記で学習した比較演算子等を使用して条件を満たしている間同じ処理を繰り返す
         *   ための構文です
         *   例えば１００回同じ内容のDebug.Log()を表示するというプログラムを作る場合
         *   
         *   Debug.Log(同じ内容)；
         *   Debug.Log(同じ内容)；
         *   Debug.Log(同じ内容)；
         * 　　　　・
         * 　　　　・
         * 　　　　・
         * 　　　　
         * 　のように100行書くのは非効率的ですね
         * 　
         * 　このような場合に繰り返し構文の真価が発揮されます
         * 　繰り返し構文を使用すると上記のプログラムと同様の結果を以下のようにあらわせます
         * 　
         * 　int x = 0;←条件判定に必要な変数を定義
         * 　
         * 　while(x < 100)
         * 　{
         * 　 Debug.Log(同じ内容);
         * 　 x++;←変数の更新
         * 　}
         *   
         *   このように１００行のコードと同じ動きをするコードがたった７行で書くことができます
         *   この繰り返し構文を上手く使用してより効率的なコードを書けるようになりましょう
         *   
         *   以下では繰り返し構文の詳しい説明を行っていきます
         * 
         * 
         *
         */

        //while文
        while (true)
        {
            int count = 0;
            if (count > 10)
            {
                break;
            }
            else
            {
                Debug.Log(count);
                i++;
            }
        }

        //for文

        for (int j = 0; i < 10; i++)
        {
            Debug.Log(j);
        }

        //for文のbreakキーワードとcontinueキーワード
        for (int k = 0; ; k++)
        {
            if (k == 0)
            {
                continue;
                //ここでカウンタ変数の処理まで飛ぶ
            }
            else if (k / 2 == 4) //変数ｋを２で割った時に５となる数（8）の場合
            {
                break;//ここでfor文から抜ける（for文が終わる）
            }
        }




    }


   
}
