using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Properties
    static bool freezTimeController=false;
    
    public static bool PlayController=false;
    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }
    public static ConfigurationData configurationData;
    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }
    }
    public static float LifeTime{
        get{return configurationData.LifeTime;}
    }
    public static float Min{
        get{return configurationData.Min;}
    }
    public static float Max{
        get{return configurationData.Max;}
    }
    public static float Score
    {
        get{return configurationData.Score;}
    }
    public static float Bonus{
        get{return configurationData.Bonus;}
    }
    public static float FreezerScore{
        get{return configurationData.FreezerScore;}
    }
    public static float SpeedScore{
        get{return configurationData.SpeedScore;}
    }
    public static float BallLeft{
        get{return configurationData.BallLeft;}
    }
    public static float FreezTime{
        get{return configurationData.FreezTime;}
    }
    

        
        
    

    #endregion
    
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData=new ConfigurationData();

    }
}
