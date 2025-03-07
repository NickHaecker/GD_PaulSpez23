using UnityEngine;

public class LiftDoor : OpenDoor
{
    [SerializeField]GameObject m_LeftWing;
    [SerializeField]GameObject m_RightWing;
    [SerializeField]AudioSource m_AudioSource;

    public override void PlayOpenSound()
    {
        m_AudioSource.Play();
    }

    protected override void OpenDoorAction()
    {
        m_LeftWing.transform.Translate(new Vector3(0, -0.5f * Time.deltaTime, 0), Space.Self);
        m_RightWing.transform.Translate(new Vector3(0, 0.5f * Time.deltaTime, 0), Space.Self);
    }
}
