namespace stack_tutorial;

public class BrowseHistoryExample
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();

    public void Visit(string url)
    {
        backStack.Push(url);
        forwardStack.Clear();
    }

    public string Back()
    {
        if (backStack.Count > 1)
        {
            forwardStack.Push(backStack.Pop());
            return backStack.Peek();
        }
        return "No more history.";
    }

    public string Forward()
    {
        if (forwardStack.Count > 0)
        {
            string url = forwardStack.Pop();
            backStack.Push(url);
            return url;
        }
        return "No more forward history.";
    }
}


