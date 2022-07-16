namespace DefaultNamespace;

public interface ISprite
{
    bool CheckUpdate();

    string FilePath { get; set; }

    void SetState(State state);

    Rectangle GetRectangle();
}