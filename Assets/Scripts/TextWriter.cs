using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;
    public UIImage uiimage;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cotest");
    }
    
    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
    
    // 文章を表示させるコルーチン(説明雑)
    IEnumerator Cotest()
    {
        /*
        uitext.DrawText("あー、あー、テステス");
        uiimage.DrawPic(1,1,0);

        uitext.DrawTest("テスター", "会話文のテストです。\nついでに改行のチェックもする");
        uiimage.DrawPic(2,3,0);
        */
        
        // 現段階までもらっているシナリオ挿入
        uitext.DrawText("今僕たちが生きているこの国は、\n世界有数の先進国であったと聞く。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("それは昔から変わっていないと僕は思う。");
        yield return StartCoroutine("Skip");
                
        uitext.DrawText("何故かと言うとこの国、\nそしてこの街が常に開発を続けているからだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("特に科学技術では今もトップクラスだと人々は口を揃えて言う。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("実際、科学技術は僕たちの生活に根付いていて、ロボットやアンドロイドは必要不可欠となっていた。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("そんな島国、ミヤビの首都、アズマが僕の住む町だ。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("生まれた時から、僕の周りにも掃除や料理、さまざまな家事をするロボットがあった。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("それがみんなにとって普通だった。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("でもそれが人類の甘えだったのかもしれない。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("科学技術は僕達に幸せと同時に不幸も運んできた。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("僕が生まれる少し前からある病気が発症し始めた。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("その病気は今のところ治すすべはない不治の病、");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("そしていかにも科学技術を発展させてきたこの国らしいと言ったら皮肉だろうか？");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("病気の名前はマシンドローム");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("体が機械になっていく病気だ。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("詳しく言うと四肢から徐々に機械化していき、中身も全て機械になった時、");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("---人格が無くなってしまう。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("そうなると人格が失われて暴走するか、\n逆に動かなくなってしまうらしい。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("政府はマシンドロームを発症した患者を施設に収容し、暴走した場合は破壊した。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("これはあくまで一時的な処置で、まだ具体的な改善策が見つかってない。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("患者を破壊するなんて殺人と一緒ではないかと抗議する人もいるが、");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("暴走した機械を止めることは困難を極めるほど、\nマシンドロームに感染した人は力が強くなっていた。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("僕も正直不満だった。");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("マシンドロームに感染した人は\n本当に人格が無くなるのか、");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("動かなくなるしかないのか？");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("どうにかして元に戻す方法はないのか？");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("でも政府でも見つけていない治療法、専門知識を持たない僕には");
        yield return StartCoroutine("Skip");
        
        uitext.DrawText("どうすることもできない......");
        yield return StartCoroutine("Skip");
    }
}
