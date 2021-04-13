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

    private Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 動作チェック：Zキーを入力するとダイチからハルに画像が変わるか
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
    }
}
