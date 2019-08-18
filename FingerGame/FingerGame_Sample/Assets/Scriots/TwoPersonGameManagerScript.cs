using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoPersonGameManagerScript : MonoBehaviour {

    public Text DeclareText;
    public GameObject ExpectPanel;
    public GameObject RaiseFingerPanel;
    private int PlayerFinger;
    private int PlayerRemainNum;
    ////private int OpponentsFinger;

    // Use this for initialization
    void Start () {

        this.PlayerRemainNum = 2;
        DeclareText.text = "";
        ExpectPanel.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void RaiseFinger(int x)
    {
        

        ExpectPanel.gameObject.SetActive(true);
        RaiseFingerPanel.gameObject.SetActive(false);

        switch (x)
        {
            case 0:
                this.PlayerFinger = 0;
                break;

            case 1:
                this.PlayerFinger = 1;
                break;

            case 2:
                this.PlayerFinger = 2;
                break;

            default:
                break;
        }

        Debug.Log("私は" + x + "を出しました");
    }


    public void ExpectNumber(int y)
    {

        switch (y)
        {
            case 0:
                DeclareText.text = "ぜろ";
                break;

            case 1:
                DeclareText.text = "いち";
                break;

            case 2:
                DeclareText.text = "に";
                break;

            case 3:
                DeclareText.text = "さん";
                break;
        }


        int OpponentsFinger = Random.Range(0, 2);

                Debug.Log("相手は" + OpponentsFinger + "を出しました"); //ちゃんとランダムに0から2までの数字が出るかの確認

        int sum = OpponentsFinger + PlayerFinger;

        Debug.Log("私は" + y + "と予測しました");
        Debug.Log("私は" + PlayerFinger + "を出しました");
        Debug.Log("相手は" + OpponentsFinger + "を出しました");
        Debug.Log("合計は" + sum + "です");

        if (y == sum)
        {
            this.PlayerRemainNum -= 1;
            Debug.Log("当たり！");
        }
        else
        {
            Debug.Log("外れ！");
        }
        //    //ランダムにでた数字とプレイヤーの押したボタンの数字の合計が一致しているか
        //    //もし一致していなければ「当たり！」そうでなければ「外れ！」

        if (this.PlayerRemainNum == 0)
        {

        }


    }

}

