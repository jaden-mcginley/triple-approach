using System;
using UnityEngine;

public class scr_PlayerSettings : MonoBehaviour
{
    [Header("Reference Scripts")]
    [Header("- Game -")]
    [SerializeField] internal scr_GameSettings gameSettings;
    [SerializeField] internal scr_GameManager gameManager;

    [Header("- Player -")]
    [SerializeField] internal scr_PlayerInput playerInput;
    [SerializeField] internal scr_PlayerMovement playerMovement;
    [SerializeField] internal scr_PlayerCollision playerCollision;

    [Space]

    [SerializeField] internal BoxCollider boxCollider;
    [SerializeField] internal SpriteRenderer spriteRenderer;
    internal scr_DefaultInput defaultInput;

    [Space]

    [SerializeField] internal GameObject punchParticle;
    [SerializeField] internal Vector3 punchParticleSpawnLocation;

    [Space]

    [SerializeField] internal GameObject kickParticle;
    [SerializeField] internal Vector3 kickParticleSpawnLocation;

    [Space]

    [SerializeField] internal bool playerWasHit;

    [Header("Animation Settings")]
    [SerializeField] internal Animator playerAnimator;

    internal string animationName_Run = "anim_Run";
    internal string animationName_DodgeLeft = "anim_DodgeLeft";
    internal string animationName_DodgeRight = "anim_DodgeRight";
    internal string animationName_Jump = "anim_Jump";
    internal string animationName_Roll = "anim_Roll";
    internal string animationName_Punch = "anim_Punch";
    internal string animationName_Kick = "anim_Kick";

    [Header("General Style Settings")]
    [SerializeField] internal bool moveUp;
    [SerializeField] internal bool moveDown;
    [SerializeField] internal bool moveLeft;
    [SerializeField] internal bool moveRight;

    [Space]

    [SerializeField] internal bool movementLocked = false;

    [Space]

    [SerializeField] internal bool primaryTriggered = false;
    [SerializeField] internal bool secondaryTriggered = false;

    [SerializeField] internal bool primaryTriggeredOnce = false;
    [SerializeField] internal bool secondaryTriggeredOnce = false;

    [Space]

    [SerializeField] internal int currentStamina = 5;
    [SerializeField] internal int maximumStamina = 5;

    [Space]

    [SerializeField] internal Style selectedStyle = Style.None;
    internal enum Style {None, Fist, Sword};

    [Space]

    [Header("Fist Style Settings")]
    [SerializeField] internal Position currentPosition = Position.None;
    internal enum Position { None, Neutral, Jump, Roll, Left, Right };

    [SerializeField] internal int fistStyleStaminaUsage = 1;

    [Space]

    [SerializeField] internal float fistStyleCurrentRechargeTimer = 5f;
    [SerializeField] internal float fistStyleMaximumRechargeTimer = 5f;

    [Space]

    [SerializeField] internal int fistStyleCurrentStaminaLeeway = 3;
    [SerializeField] internal int fistStyleMaximumStaminaLeeway = 3;

    [Space]

    [Header("Sword Style Settings")]
    [SerializeField] internal Stance currentStance = Stance.None;
    internal enum Stance { None, Neutral, Up, Down, Left, Right };

    [SerializeField] internal int swordStyleStaminaUsage = 3;

    [Space]

    [SerializeField] internal float currentParryTimer = 0f;
    [SerializeField] internal float maximumParryTimer = .3f;

    [SerializeField] internal bool charge = false;
    [SerializeField] internal bool parry = false;

    [Space]

    [SerializeField] internal float chargeMultiplier = 0f;

    [Space]

    [SerializeField] internal float swordStyleCurrentRechargeTimer = 5f;
    [SerializeField] internal float swordStyleMaximumRechargeTimer = 5f;

    [Space]

    [SerializeField] internal int swordStyleCurrentStaminaLeeway = 1;
    [SerializeField] internal int swordStyleMaximumStaminaLeeway = 1;

    private void Awake()
    {
    }
}