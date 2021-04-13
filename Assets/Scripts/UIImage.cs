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
        // 動作チェック：Zキーを入力するとダイチからハルに画像が変わるか
        
        /* 
        if( Input.GetKeyDown(KeyCode.Z) )
        {
            sprite = hikari;
            image_C.sprite = sprite;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            sprite = haru;
            image_C.sprite = sprite;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            sprite = meari;
            image_C.sprite = sprite;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            sprite = mizuki;
            image_C.sprite = sprite;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            sprite = sora;
            image_C.sprite = sprite;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            sprite = daiti;
            image_C.sprite = sprite;
        }
        */
        
    }
    
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
        image_C.sprite = (place == 0) ? sprite : daiti;
        image_L.sprite = (place == 1) ? sprite : daiti;
        image_R.sprite = (place == 2) ? sprite : daiti;
    }
}
