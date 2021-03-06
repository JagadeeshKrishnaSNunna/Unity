using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    static float paddleMoveUnitsPerSecond = 10;
    static float ballImpulseForce = 200;
    static float lifeTime=10;
    static float min=5;
    static float score=5;
    static float max=10;
    static float bonus=10;
    static float freezerScore=10;
    static float speedScore=25;
    static float ballLeft=10;
    static float freezTime=4;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }
    public float LifeTime{
        get{return lifeTime;}
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }
    public float Min
    {
        get { return min; }    
    }
    public float Max
    {
        get { return max; }    
    }
    public float Score
    {
        get { return score; }    
    }
    public float Bonus
    {
        get { return bonus; }    
    }
    public float FreezerScore
    {
        get { return freezerScore; }    
    }
    public float SpeedScore
    {
        get { return speedScore; }    
    }
    public float BallLeft
    {
        get { return ballLeft; }    
    }
    public float FreezTime
    {
        get { return freezTime; }    
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader streamReader = null;      
        //string[] name;
        string[] values;
        try
        {
            streamReader = File.OpenText(Path.Combine(Application.streamingAssetsPath, "Book1.csv"));
            string readLine = streamReader.ReadLine();
            readLine.Split(',');
            readLine = streamReader.ReadLine();
            values = readLine.Split(',');
            paddleMoveUnitsPerSecond=float.Parse(values[1]);
            ballImpulseForce=float.Parse(values[0]);
            lifeTime=float.Parse(values[2]);
            min=float.Parse(values[3]);
            max=float.Parse(values[4]);
            score=float.Parse(values[5]);
            bonus=float.Parse(values[6]);
            freezerScore=float.Parse(values[7]);
            speedScore=float.Parse(values[8]);
            ballLeft=float.Parse(values[9]);
            freezTime=float.Parse(values[10]);
        }
        finally
        {
            if(streamReader != null)
            streamReader.Close();
        }
        
    }

    #endregion
}
