namespace linked_list_tutorial;

public class SongNode
{
    public string SongName;
    public SongNode Next;

    public SongNode(string songName)
    {
        SongName = songName;
        Next = null;
    }
}

public class Playlist
{
    private SongNode head;

    public Playlist()
    {
        head = null;
    }

    // Add a song to the end of the playlist
    public void AddSong(string songName)
    {
        SongNode newNode = new SongNode(songName);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            SongNode curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = newNode;
        }
    }
    // we can remove the song 
    public void RemoveSong(string songName)
    {
        if (head == null) return;
        if (head.SongName == songName)
        {
            head = head.Next;
            return;
        }

        SongNode curr = head;
        while (curr.Next != null && curr.Next.SongName != songName)
        {
            curr = curr.Next;
        }

        if (curr.Next != null)
        {
            curr.Next = curr.Next.Next;
        }
    }
    // Search for a song in the playlist
    public bool SearchSong(string songName)
    {
        SongNode current = head;
        while (current != null)
        {
            if (current.SongName == songName)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    // Display the playlist
    public void DisplayPlaylist()
    {
        SongNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.SongName);
            current = current.Next;
        }
    }
}