using UnityEngine;

/// <summary>
/// Example Satellite Reign pause mod.
/// </summary>
public class Pause : ISrPlugin
{
	protected TimeManager.TimeScaler m_TacticalPauseTimeScaler;

    /// <summary>
    /// Plugin initialization 
    /// </summary>
    public void Initialize()
    {
		Debug.Log("Initializing Satellite Reign pause mod");
		m_TacticalPauseTimeScaler = TimeManager.AddTimeScaler();
    }

    /// <summary>
    /// Called once per frame.
    /// </summary>
    public void Update()
    {
		if (Manager.Get().GameInProgress) 
		{
			if (Input.GetKeyDown(KeyCode.Pause))
			{
                if (m_TacticalPauseTimeScaler.Paused) 
				{
                    m_TacticalPauseTimeScaler.Reset();
                } 
				else 
				{
                    m_TacticalPauseTimeScaler.Pause();
                }
			}
		}
    }

    public string GetName()
    {
        return "Tactical pause.";
    }
}

