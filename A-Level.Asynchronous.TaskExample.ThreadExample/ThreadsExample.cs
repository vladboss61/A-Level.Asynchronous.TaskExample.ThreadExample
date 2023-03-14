namespace A_Level.Asynchronous.TaskExample.ThreadExample;

internal sealed class ThreadsExample
{
    public static void ThreadExample()
    {
        var thread = new Thread(() => { });
        thread.Start();
    }
}
