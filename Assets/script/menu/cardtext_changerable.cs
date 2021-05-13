using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardtext_changerable : MonoBehaviour
{
    public TextMesh card_text = null;

    public void cardtext_changer(carddata text)
    {
        card_text.text = text.cardweapon.name;
    }
}