using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PyramidGame {

public enum eCardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardPyramid : Card
{
    [Header("Set Dynamically: CardPyramid")]
    public eCardState state = eCardState.drawpile;
    public List<CardPyramid> hiddenBy = new List<CardPyramid>();
    public SlotDef slotDef;

    
    override public void OnMouseUpAsButton()
    {
        //PyramidGame.Prospector.S.CardClicked(this);
        base.OnMouseUpAsButton();
    }

    
    public void UpdateState()
    {
        if (faceUp)
        {
            state = eCardState.tableau;
        }
        else
        {
            state = eCardState.drawpile;
        }
    }
}
}
