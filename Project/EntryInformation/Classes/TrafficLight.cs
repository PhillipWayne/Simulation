﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TrafficLight
{
    public System.Timers.Timer greenLightTimer;
    int feederID;
    Crossing crossing;

    public TrafficLight(Crossing crossing, int greenLight, int feederID)
    {
        this.feederID = feederID;
        this.GreenLight = greenLight;
        greenLightTimer = new System.Timers.Timer();
        greenLightTimer.Interval = (this.GreenLight*10000);
        greenLightTimer.Elapsed += greenLightTimer_Elapsed;
        this.crossing = crossing;
    }

    void greenLightTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        greenLightTimer.Stop();
        crossing.Feeders[(feederID % 4)].TrafficLight.greenLightTimer.Start();
    }
	public int GreenLight
	{
		get;
		set;
	}

	public virtual bool State
	{
		get;
		set;
	}

	public virtual int Time
	{
		get;
		set;
	}

	public virtual void SetState()
	{
		throw new System.NotImplementedException();
	}

	public virtual void GetState()
	{
		throw new System.NotImplementedException();
	}

}

