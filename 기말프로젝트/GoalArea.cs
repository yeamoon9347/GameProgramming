using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public static bool goal;

    void Start()
    {
        goal = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Player.cnt == 7)
        {
            goal = true;
        }
    }
}
