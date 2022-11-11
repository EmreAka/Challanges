using Simulation.Blocks;

List<List<IBlock>> blocks = new()
{
    new List<IBlock>() { new ClosedButton(), new OpenButton()},
    new List<IBlock>() { new ClosedButton(), new ClosedButton() },
};

var isOutputTrue = false;
List<bool> statusOfParallelBlocks = new();

foreach (var buttons in blocks)
{
    bool wasOpen = false;
    foreach (var button in buttons)
    {
        if (button.IsOpen == false)
        {
            continue;
        }
        else
        {
            statusOfParallelBlocks.Add(false);
            wasOpen = true;
        }
    }
    if (wasOpen == false)
        statusOfParallelBlocks.Add(true);
}

foreach(var status in statusOfParallelBlocks)
{
    if (status)
    {
        isOutputTrue = true;
    }
}

Console.WriteLine(isOutputTrue);