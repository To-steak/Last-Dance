using UnityEngine;

public class Handgun : MonoBehaviour, IAttack
{
    public void Attack()
    {
        print("I'm a handgun");
    }
}
