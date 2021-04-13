using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    // 画像の表示場所
    public Image image_C;
    public Image image_L;
    public Image image_R;
    
    // 登場キャラ達
    public Sprite daiti;
    public Sprite haru;
    public Sprite hikari;
    public Sprite meari;
    public Sprite mizuki;
    public Sprite sora;
    
    // 表情差分

    private Sprite sprite;

    void Start()
    {
        
    }

    void Update()
    {
    }
    
    // DrawPic(場所、キャラクター、表情差分)でイラストを表示
    // 表示しない時用の無印枠が必要。
    public void DrawPic ( int place, int chara, int face )
    {
        // キャラクターの選択
        sprite = (chara == 1) ? sprite = hikari :
                 (chara == 2) ? sprite = haru   :
                 (chara == 3) ? sprite = meari  :
                 (chara == 4) ? sprite = mizuki :
                 (chara == 5) ? sprite = sora   :
                                sprite = daiti  ;
                
        // 画像の挿入場所
        switch (place)
        {
            case 1:  image_L.sprite = sprite; break;
            case 2:  image_R.sprite = sprite; break;
            default: image_C.sprite = sprite; break;
        }
    }
}
