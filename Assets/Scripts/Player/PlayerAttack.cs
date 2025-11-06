using UnityEngine;
public class PlayerAttack : MonoBehaviour, IAttack
{
    public IAttack currentWeapon;
    public GameObject equipWeapon;

    public void Awake()
    {
        // 나중에 무기 교체 함수 필요함 일단은 awake에서 테스트
        currentWeapon = equipWeapon.GetComponent<IAttack>();
    }
    public void Attack()
    {
        currentWeapon.Attack();
    }
}