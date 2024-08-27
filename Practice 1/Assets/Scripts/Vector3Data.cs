using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void UpdateValue(Vector3 num)
    {
        value += num;
    }
}

