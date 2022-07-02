using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    TextMeshProUGUI smstext;
    int currentpage = 1;

    public void onClick()
    {
        int totalpages = smstext.textInfo.pageCount;

        if (currentpage < totalpages)
        {
            currentpage++;
            smstext.pageToDisplay++;
        }
    }
}
