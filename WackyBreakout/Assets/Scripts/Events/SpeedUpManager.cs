using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SpeedUpManager 
{
    static List<SpeedBlock> invoker=new List<SpeedBlock>();
    static List<UnityAction> Speedlistener=new List<UnityAction>();

    public static void AddInvoker(SpeedBlock speedBlock){
        invoker.Add(speedBlock);
        foreach(UnityAction ua in Speedlistener){
            speedBlock.AddSpeedUpListener(ua);
        }
    }

    public static void AddListener(UnityAction lis){
        Speedlistener.Add(lis);
        foreach(SpeedBlock sb in invoker){
            sb.AddSpeedUpListener(lis);
        }
    }
}
