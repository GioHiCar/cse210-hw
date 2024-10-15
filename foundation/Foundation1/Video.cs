using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length, List<Comment> comments){
        _title = title;
        _author = author;
        _length = length;
        foreach(Comment comment in comments){
            _comments.Add(comment);
        }
    }
    public int GetNumberOfComments(List <Comment> _comments){
        int numOfComments = _comments.Count();
        return numOfComments;
    }
    public void DisplayVideo(){
        Console.WriteLine($"'{_title}' by {_author} \n({_length} secconds)\n{GetNumberOfComments(_comments)} Comments:");
        foreach(Comment comment in _comments){
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}