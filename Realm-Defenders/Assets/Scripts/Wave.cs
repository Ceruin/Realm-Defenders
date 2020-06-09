using System;

[Serializable]
public class Wave
{
    public int secondsTillStart;
    public float spawnerSpeed;
    public bool isStarted;

    public Wave(int secondsTillStart, float spawnerSpeed, bool isStarted = false)
    {
        this.secondsTillStart = secondsTillStart;
        this.spawnerSpeed = spawnerSpeed;
        this.isStarted = isStarted;
    }
}
