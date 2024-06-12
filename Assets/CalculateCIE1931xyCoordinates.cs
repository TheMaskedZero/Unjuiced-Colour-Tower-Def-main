using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateCIE1931xyCoordinates : MonoBehaviour
{

    List<Vector2> CIE1931xyCoordinates;
    
    int nDirections = 12;
    int nCircles = 6;

    float radius;

    public List<Vector2> CreateCoordinates(Vector2 centerCoordinate, float circleExpansion=0.025f)
    {
        CIE1931xyCoordinates = new List<Vector2>();
        for(int direction = 0; direction <= nDirections; direction++) 
        {
            for(int circle = 1; circle <= nCircles; circle++)
            {
                Vector2 currentCoordinate = new Vector2(Mathf.Cos((2*Mathf.PI / nDirections) * direction) * (circle * circleExpansion)+centerCoordinate[0], Mathf.Sin((2*Mathf.PI / nDirections) * direction) * (circle * circleExpansion) + centerCoordinate[1]);
                CIE1931xyCoordinates.Add(currentCoordinate);
            }
        }

        return CIE1931xyCoordinates;
    }
}
