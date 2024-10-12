using System;

public class VideoList{
    public List<Video> _videos = new List<Video>();

    public VideoList(){

    }

    public void VideoInformation(){
        foreach (var video in _videos)
        {
            video.PrintingVideoDetails();
        }
    }
}