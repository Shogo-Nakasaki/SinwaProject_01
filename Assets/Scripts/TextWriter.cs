using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{

    public UIText uitext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cotest");

    }

    // 文章を表示させるコルーチン(説明雑)
    IEnumerator Cotest()
    {
        uitext.DrawText("あー、あー、テステス");
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;

        uitext.DrawTest("テスター", "会話文のテストです。\nついでに改行のチェックもする");
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;

        uitext.DrawTest("テスター", "長文を記入した際に改行されるかのチェックだけども文章思いつかない。");
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
}
