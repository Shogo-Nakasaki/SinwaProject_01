using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    public Image image;
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
            // image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
    }
}
