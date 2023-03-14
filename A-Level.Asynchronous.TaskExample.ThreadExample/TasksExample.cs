namespace A_Level.Asynchronous.TaskExample.ThreadExample;

internal class TasksExample
{
    public static void ThreadExample()
    {
        var task = new Task(() => { });
        task.Start();
    }
}
