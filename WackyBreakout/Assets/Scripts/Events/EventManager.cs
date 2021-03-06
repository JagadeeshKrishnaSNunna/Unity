using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{
    static FreezerBlock invoker;
    static UnityAction listener;
    static UnityAction<float> AddPointslistener;
    static Block AddPointsinvoker;
    static BallSpawner Ballinvoker;
    static UnityAction Balllistener,BallSpawnListener;
    static RandomBallSpanner randomBallSpanner;
    static Ball ball; 

    // Start is called before the first frame update
    public static void AddInvoker(FreezerBlock fzb){
        invoker=fzb;
        if(listener!=null){
            invoker.AddcollisionListener(listener);
        }

    }
    public static void AddListener(UnityAction lis){
        listener=lis;
        if(invoker!=null){
            invoker.AddcollisionListener(lis);
        }

    }
    public static void AddPointsInvoker(Block fzb){
        AddPointsinvoker=fzb;
        if(AddPointslistener!=null){
            AddPointsinvoker.AddAddPointsListener(AddPointslistener);
        }

    }
    public static void AddPointsListener(UnityAction<float> lis){
        AddPointslistener=lis;
        if(AddPointsinvoker!=null){
            AddPointsinvoker.AddAddPointsListener(lis);
        }

    }
    public static void AddBallDecrementInvoker(BallSpawner fzb){
        Ballinvoker=fzb;
        if(Balllistener!=null){
            Ballinvoker.AddBallDecrementListener(Balllistener);
        }

    }
    public static void BallDecrementListener(UnityAction lis){
        Balllistener=lis;
        if(Ballinvoker!=null){
            Ballinvoker.AddBallDecrementListener(lis);
        }

    }
    public static void AddBallSwanInvoker(Ball fzb){
        ball=fzb;
        if(BallSpawnListener!=null){
            ball.BallSpawnListener(BallSpawnListener);
        }

    }
    public static void AddBallSwanInvoker(RandomBallSpanner fzb){
        randomBallSpanner=fzb;
        if(BallSpawnListener!=null){
            randomBallSpanner.BallSpawnListener(BallSpawnListener);
        }

    }
    public static void AddBallSpawnListener(UnityAction lis){
        BallSpawnListener=lis;
        if(ball!=null){
            ball.BallSpawnListener(lis);
        }

    }
}
