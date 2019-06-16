#pragma strict

function Start()
{
    var aud : AudioSource = GetComponent(AudioSource);
    aud.clip = Microphone.Start(null, true, 1, 22050);
    aud.loop = true;
    while (!(Microphone.GetPosition(null) > 0))
    {
        aud.Play();
    }
}

function Update () {

}