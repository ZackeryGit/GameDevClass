using UnityEngine;

[CreateAssetMenu]
public class IntData : MonoBehaviour
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}

