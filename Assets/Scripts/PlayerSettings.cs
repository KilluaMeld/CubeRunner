using UnityEngine;
using TMPro;

public class PlayerSettings : MonoBehaviour
{
    public static PlayerSettings instance = null;

    public Upgrade Damage;
    public Upgrade ShootingSpeed;
    public Upgrade BulletSize;
    public Currency Gem;


    void Awake()
    {
        if (instance == null)
        { 
            instance = this; 
        }
        else
        {
            Destroy(gameObject); 
        }
        Application.targetFrameRate = 120;

        DontDestroyOnLoad(this.gameObject);

        Damage.ValueChanged?.Invoke();
        ShootingSpeed.ValueChanged?.Invoke();
        BulletSize.ValueChanged?.Invoke();
        Gem.ValueChanged?.Invoke();
    }
}
