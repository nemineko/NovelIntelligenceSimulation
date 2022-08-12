using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HexManager : MonoBehaviour
{
    public SpriteRenderer hexSprite;
    [SerializeField] Sprite hexBlue;
    [SerializeField] Sprite hexYellow;
    [SerializeField] Sprite hexGreen;
    [SerializeField] Sprite hexRed;
    public enum HexColour
    {
        Blue,
        Yellow,
        Green,
        Red,
    }
    public HexColour hexColour;
    private void Start()
    {
        HexSelect();
    }
    private void OnMouseOver()
    {
        PopUpWindow();
    }
    void HexSelect()
    {
        switch (this.hexColour)
        {
            case HexColour.Blue:
                HexBlue();
                break;
            case HexColour.Yellow:
                HexYellow();
                break;
            case HexColour.Green:
                HexGreen();
                break;
            case HexColour.Red:
                HexRed();
                break;
        }
    }
    void HexBlue()
    {
        hexSprite.sprite = hexBlue;
        bool tileAvailable = false;
        TileAvailable(tileAvailable);

    }
    void HexYellow()
    {
        hexSprite.sprite = hexYellow;
        bool tileAvailable = true;
        TileAvailable(tileAvailable);
    }
    void HexGreen()
    {
        hexSprite.sprite = hexGreen;
        bool tileAvailable = true;
        TileAvailable(tileAvailable);
    }
    void HexRed()
    {
        hexSprite.sprite = hexRed;
        bool tileAvailable = true;
        TileAvailable(tileAvailable);
    }
    void PopUpWindow()
    {
        Debug.Log("敵が出現する可能性");
    }
    void TileAvailable(bool tileAvailable)
    {
        if (tileAvailable == true)
        {
            //タイルの上に目の駒を置けるようにする
        }
        else if (tileAvailable == false)
        {
            //タイルの上に目の駒を置けないようにする
            //目の駒を元の位置に戻す
        }
    }
    void BuildAvailable()
    {
        //目の駒が上に乗っている状態のとき、建築済みか否か診断
    }
    void BuildFacility(bool alreadyBuild)
    {
        //目の駒が上に乗っている間、建築をする
    }
}
