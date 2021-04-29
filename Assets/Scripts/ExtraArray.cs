
[System.Serializable]
public class ExtraArray
{
    [System.Serializable]
    public struct data
    {
        public UnityEngine.Transform[] pos;
    }

    public data[] groups;
}
