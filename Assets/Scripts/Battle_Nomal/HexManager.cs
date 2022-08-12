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
        Debug.Log("�G���o������\��");
    }
    void TileAvailable(bool tileAvailable)
    {
        if (tileAvailable == true)
        {
            //�^�C���̏�ɖڂ̋��u����悤�ɂ���
        }
        else if (tileAvailable == false)
        {
            //�^�C���̏�ɖڂ̋��u���Ȃ��悤�ɂ���
            //�ڂ̋�����̈ʒu�ɖ߂�
        }
    }
    void BuildAvailable()
    {
        //�ڂ̋��ɏ���Ă����Ԃ̂Ƃ��A���z�ς݂��ۂ��f�f
    }
    void BuildFacility(bool alreadyBuild)
    {
        //�ڂ̋��ɏ���Ă���ԁA���z������
    }
}
