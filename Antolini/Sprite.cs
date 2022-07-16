namespace DefaultNamespace;

public class Sprite : ISprite
{
    
    private State _state;
    private GameObjectType _objType;
    private string _folder;
    private string _filename;
    private int _tileCount;
    private int _lastUpdate;
    private static readonly Rectangle _characterRectangle = new Rectangle(new Point2D(0, 0), new Point2D(1, 1.4));
    private static readonly Rectangle _bulletRectangle = new Rectangle(new Point2D(0, 0), new Point2D(0.3, 0.3));
    
    public Sprite(GameObjectType objType, State state)
    {
        _objType = objType;
        _state = state;
        _tileCount = 1;
    }

    public override bool CheckUpdate() {
        int updateDelay = 0;
        switch (_objType) {
            case PLAYER:
                updateDelay = 1200;
                break;
            case BOSS1:
                updateDelay = 4000;
                break;
            case BOSS2:
                updateDelay = 3500;
                break;
            case BOSS3:
                updateDelay = 5000;
                break;
            case BOSS4:
                updateDelay = 4500;
                break;
            case BOSS5:
                updateDelay = 4500;
                break;
            case BOSS6:
                updateDelay = 5000;
                break;
            case BULLET_PLAYER:
                updateDelay = 3000;
                break;
            case BULLET_BOSS_1:
                updateDelay = 3000;
                break;
            case BULLET_BOSS_2:
                updateDelay = 3500;
                break;
            case BULLET_BOSS_3:
                updateDelay = 3500;
                break;
            case BULLET_BOSS_4:
                updateDelay = 3000;
                break;
            case BULLET_BOSS_5:
                updateDelay = 2500;
                break;
            case BULLET_BOSS_6:
                updateDelay = 2000;
                break;
            default: {}
        }
        long currentTime = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        if (currentTime - _lastUpdate >= updateDelay) {
            _lastUpdate = currentTime;
            return true;
        }
        return false;
    }

    public override string FilePath
    {
        get;
        set {
            if(_objType.Equals(GameObjectType.BOSS1) || _objType.Equals(GameObjectType.BOSS2)
                    || _objType.Equals(GameObjectType.BOSS3) || _objType.Equals(GameObjectType.BOSS4)
                    || _objType.Equals(GameObjectType.BOSS5) || _objType.Equals(GameObjectType.BOSS6)) {
                _folder = "boss";
                _filename = "boss_front_2.png";
            } else if(_objType.Equals(GameObjectType.PLAYER)) {
                _folder = "player";
                this.SetupSpriteFilepath();
            } else if(_objType.Equals(GameObjectType.BULLET_BOSS_1) || _objType.Equals(GameObjectType.BULLET_BOSS_2)
                    || _objType.Equals(GameObjectType.BULLET_BOSS_3) || _objType.Equals(GameObjectType.BULLET_BOSS_4)
                    || _objType.Equals(GameObjectType.BULLET_BOSS_5) || _objType.Equals(GameObjectType.BULLET_BOSS_6)) {
                _folder = "bullets";
                _filename = "boss_bullet.png";
            } else if(_objType.Equals(GameObjectType.BULLET_PLAYER)) {
                _folder = "bullets";
                _filename = "player_bullet.png";
            }
            FilePath = _folder + "/" + _filename;
        }
    }

    private void SetupSpriteFilepath() {
        _filename = _folder;
        this.SetSpriteDirection();
        this.SetSpriteNumber();
        _filename = _filename.Concat(".png");
    }

    private void SetSpriteDirection() {
        switch (_state) {
            case UP:
                _filename = _filename.Concat("_back");
                break;
            case DOWN:
                _filename = _filename.Concat("_front");
                break;
            case RIGHT:
                _filename = _filename.Concat("_right");
                break;
            case LEFT:
                _filename = _filename.Concat("_left");
                break;
            default: {}
        }
    }

    private void SetSpriteNumber() {
        switch(_tileCount) {
            case 1:
                _filename = _filename.Concat("_1");
                _tileCount++;
                break;
            case 2:
                _filename = _filename.Concat("_2");
                _tileCount++;
                break;
            case 3:
                _filename = _filename.Concat("_3");
                _tileCount = 1;
                break;
            default: {}
        }
    }

    public override void SetState(State state) {
		_state = state;
	}

    public override Rectangle GetRectangle() {
        if (_objType.GetCollisionType().Equals(GameCollisionType.ENTITY)) return _characterRectangle;
        else if (_objType.GetCollisionType().Equals(GameCollisionType.BULLET)) return _bulletRectangle;
        return null;
    }

}