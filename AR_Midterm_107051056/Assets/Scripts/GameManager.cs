using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("石頭蛙")]
    public Transform StoneFrog;
    
    [Header("太空人")]
    public Transform Astronaut;

    [Header("石頭蛙控制元件")]
    public Animator AniStoneFrog;
    [Header("太空人控制元件")]
    public Animator AniAstronaut;

    private void Update()
    {
        
    }

    public void PlayAnimation(string aniname)
    {
        AniStoneFrog.SetTrigger(aniname);
        AniAstronaut.SetTrigger(aniname);
    }
}
