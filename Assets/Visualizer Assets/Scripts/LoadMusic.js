#pragma strict
 
import System.Collections.Generic;
import System.IO;
import UnityEngine.UI;
 
static var path : String = "./"; // Is equal to where you have your executable
static var fileTypes : String[] = ["ogg", "wav"]; // Valid file types
 
static var files : FileInfo[];
static var audioSource : AudioSource;
static var audioClips : List.<AudioClip> = new List.<AudioClip>();
public var Count : int = 0;

public var SongTextObject : Text;
public var SongNumber : int = 0;
public var NoMusic : boolean = false;
public var Starter: boolean = false;
 
function Start () {
    // If in editor the path is in Assets folder
    if (Application.isEditor)
        path = "Assets/";
 
    // Set an AudioSource to this object
    audioSource = GetComponent.<AudioSource>();
    if(audioSource == null)
        audioSource = gameObject.AddComponent(AudioSource);
 
    // Find files in directory      
    yield GetFilesInDirectory();
 
}

function playRandomMusic(){

	if(audioClips.Count == 0)
		GetFilesInDirectory();

    SongNumber = Random.Range(0,audioClips.Count);
    audioSource.clip = audioClips[SongNumber];
    audioSource.Play();
    SongTextObject.text = audioSource.clip.name;
    SongTextObject.text = SongTextObject.text.Substring(0, SongTextObject.text.Length - 4);
    audioClips.Remove(audioClips[SongNumber]);
}

function Update()
{
    if(Starter)
    {
        if(!audioSource.GetComponent.<AudioSource>().isPlaying)
        {
            playRandomMusic();
        }
    }
	

	
    if(Input.GetKeyDown(KeyCode.Space))
    {
    	if(!Starter){
	        playRandomMusic();
	        Starter = true;
        }
        else
        	playRandomMusic();
    }
}


 
function GetFilesInDirectory () {
    var info : DirectoryInfo = new DirectoryInfo(path);
    files = info.GetFiles();
    for (var file : FileInfo in files) {
        var extension : String = Path.GetExtension(file.FullName);
        if (ValidType(extension))
            yield LoadFile(file.FullName);
    }
}
 
function ValidType (extension : String) : boolean {
    for (var validExtension : String in fileTypes)
        if (extension.IndexOf(validExtension) > -1)
            return true;
    return false;
    }
 
    function LoadFile (path : String) {
        var www : WWW = new WWW("file://"+path);
        var clip : AudioClip = www.GetAudioClip();
        while (!clip.isReadyToPlay)
            yield;
        clip = www.GetAudioClip(false);
        var parts : String[] = path.Split("\\"[0]);
    
        clip.name = parts[parts.Length-1];
        audioClips.Add(clip);
        Count++;
    }