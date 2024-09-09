using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


//Bossクラスを作る
public class Boss
{
    private int mp = 53;

    //魔法攻撃の関数Magicの宣言
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
}

public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
    //課題---------------------------------------------------------------------
        //int型配列arrayを宣言して好きな値で初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //for文で順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //for文で逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    //発展課題------------------------------------------------------------------
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //魔法攻撃用の関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        //もう一度魔法攻撃用の関数を呼び出してmpが足りないメッセージを確認する
        lastboss.Magic();
    }
}