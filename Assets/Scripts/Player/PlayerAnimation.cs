using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void JumpAnim()
    {
        if (animator != null)
        {
            animator.SetTrigger("OnJump");
        }
    }

    public void DieAnim()
    {
        if (animator != null)
        {
            animator.SetTrigger("OnDie");
            print("Die Anim");
        }
    }
}
