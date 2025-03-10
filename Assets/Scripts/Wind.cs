using UnityEngine;

public class Wind : MonoBehaviour
{
    public PlayerScript PS;
    public AreaEffector2D wind;

    void Start()
    {
        wind.forceMagnitude = 0;
    }

    void Update()
    {
        if (PS.Score >= 50)
        {
            wind.forceMagnitude = 15;
            wind.forceAngle = 180;
        }
        else if (PS.Score >= 35)
        {
            wind.forceMagnitude = 5;

        }
        else if (PS.Score >= 25)
        {
            wind.forceMagnitude = 15;
        }
        else if(PS.Score >= 15)
        {
            wind.forceMagnitude = 10;
        }
        else if(PS.Score >= 5)
        wind.forceMagnitude = 5;
    }
}
