using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss　//新しいクラス
{
    private int hp = 100;　　//アクセス修飾子のprivateを入れることで他クラスから呼び出せない
    private int power = 25;　//hp,powerなどのメンバ変数を設定
    private int mp = 53;
    

    public void Attack()   
    {
        Debug.Log(this.power + "のダメージを与えた");  //thisは無くてもいいが、付けることで「このクラスのメンバ変数を使う」ことを明示する
                                                       //また、thisはメンバ変数、その他はローカル変数であることが見分けられる
    }
    public void Defence(int damage) 
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
        if (this.hp <= 0) 
        {
            Debug.Log("中ボスを倒した。");
        }

    }

    // Stage4　発展課題
    public void Magic()  
        
    {
        for (int i = 0; i <= 10; i++)
        {
            if (this.mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }
    }

}
public class Test : MonoBehaviour
{



    //関数--------------------------------------------------------------------------------


        // 引数なし、返り値なし
        void Hello()
        {
        Debug.Log("Goodbye,UnityChan");
        }

        // 引数あり、返り値なし
        void HelloName(string name)
        {
        Debug.Log("Hello" + name);
        }

        void Strong(int strong)
        {
        Debug.Log("初期筋力は" + strong + "です");
        }

        // 引数あり、返り値あり
        int Add(int a, int b, int c )
        {
        int d = a + b + c;
        return d;
        }

       



    void Start() //Start時に動作するのみ
    {
        // 関数の引数から
        Hello(); 　　　　　　　// 引数なし、返り値なし 
        
        HelloName("Unity");　　// 引数あり、返り値なし
        Strong(300);           // 同上
        
        int num = Add(3, 6, 9);   // Add関数に3,6の引数を渡し、返り値をnum変数に代入する
        Debug.Log(num);


        // 所持金の設定
        int money = 50;


    //配列 -------------------------------------------------------------------------


        //「配列」をint型で5個存在することを設定
        // points[5]まで入力しTest → ERROR:Index was outside the bounds of the array.
        int[] points = new int[5];
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 40;

        // 「配列」で設定したpointsの表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // 「配列」の応用的な書き方
        int[] points2 = { 30, 20, 50, 10, 80, 15, 60, 100 };
        for (int i = 0; i < points2.Length; i++)        //for(リストのどの位置の値からか；　どこの間まで作業するか；　足すか減らすか；)
            if (points2[i] >= 50)
            {
                Debug.Log(points2[i]);
            }



    //if文--------------------------------------------------------------------------


        // 三項演算子(if～else文を1行で書くやり方)：整数でnumを設定、valの内容からnumの数値に影響して所持金を差し引きできる
        int number= 2;
        int val = (number == 1) ? money - 100 : money + 150;

        // 所持金の表示
        Debug.Log(val);

        // 所持金数から売買の方法が変わる
        if (val <= 50)
        {
            Debug.Log("Sell a sword");

        }
        else if (val >= 200)
        {
            Debug.Log("Buy a sword");
        }
        else
        {
            Debug.Log("Buy a portion");
        }


    //if文----------------------------------------------------------------------------


        // if文を使い初期化した数値から表示される分岐を設定
        int a = 2;
        if (a == 3)
        {
            int b = 5;
            Debug.Log(b);
        }
        else
        {
            Debug.Log(a);
        }




    //for文----------------------------------------------------------------------


        // for文により100まで１を足し続ける
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }


    //クラス、インスタンス、メンバ------------------------------------------------
        Boss lastboss = new Boss();  //クラス名、変数名作成　＝　Bossクラスのインスタンスを生成して代入
        lastboss.Attack();
        lastboss.Defence(3);         //インスタンス名　．（）内のdefenceの値を入れる
        lastboss.Magic();
       

        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(100);





    //Stage4 課題

        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++) 
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--) 
        {
            Debug.Log(array[i]);
        }


    }




    // Update is called once per frame
    void Update()
        {

        }
    }

