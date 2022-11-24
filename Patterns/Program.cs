public interface IButton
{
    void render();
    void OnClick();
}

public class WindowsButton : IButton
{
    public void OnClick() => Console.WriteLine("Windows btn");
    public void render() => Console.WriteLine("Windows render");
}

public class HtmlButton : IButton
{
    public void OnClick() => Console.WriteLine("Html btn");
    public void render() => Console.WriteLine("Html render");
}


public abstract class Dialog
{
    public void render()
    {
        IButton okButton = CreateButton();
        okButton.OnClick();
        okButton.render();
    }

    public abstract IButton CreateButton();
}

public class WindowsDialog : Dialog
{
    public override IButton CreateButton() => new WindowsButton();
}

public class WebDialog : Dialog
{
    public override IButton CreateButton() => new HtmlButton();
}

public class Program
{
    public static void Main()
    {
        Dialog dialog = new WindowsDialog();
        dialog.render();

        dialog = new WebDialog();
        dialog.render();
    }
}