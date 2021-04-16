﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    // nameText:喋っている人の名前
    // talkText:喋っている内容やナレーション

    public Text nameText;
    public Text talkText;

    public bool playing = false;
    public float textSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // 関数：クリックで次のページを表示させる
    public bool IsClicked()
    {
        if (Input.GetMouseButtonDown(0)) return true;
        return false;
    }

    // 関数：ナレーション用のテキスト生成
    public void DrawText ( string text)
    {
        nameText.text = "";
        StartCoroutine("CoDrawText", text);
    }
    // 関数：通常会話用のテキスト生成
    public void DrawText ( string name, string text)
    {
        nameText.text = name + "\n「";
        StartCoroutine("CoDrawText", text + "」");
    }

    // テキストがヌルヌル出てくるためのコルーチン
    IEnumerator CoDrawText ( string text )
    {
        playing = true;
        float time = 0;
        while ( true )
        {
            yield return 0;
            time += Time.deltaTime;

            // クリックされると一気に表示
            if ( IsClicked() ) break;

            int len = Mathf.FloorToInt ( time / textSpeed);
            if (len > text.Length) break;
            talkText.text = text.Substring(0, len);
        }
        talkText.text = text;
        yield return 0;
        playing = false;
    }
}
