using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup: PickupModal
{
    bool coroutineTriggered = false;

    public void ApplyAffect()
    {
        var sceneManagerData = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<DataStore>();
        
        if(slug == "invert")
        {
            InvertTurnDirection(sceneManagerData);
        }
    }

    private void InvertTurnDirection(DataStore scnMgr)
    {

        scnMgr.TurnDirection *= -1f;
        if (!coroutineTriggered)
        {
            StartCoroutine("Delay");
        }
        else
        {
            coroutineTriggered = false;
        }
    }

    private IEnumerator Delay()
    {
        coroutineTriggered = true;
        yield return new WaitForSeconds((float)duration);
        ApplyAffect();
    }
}