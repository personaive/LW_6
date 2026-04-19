using System;

public class Device
{
    private bool _isOn;
    private bool _hasPower;

    public Device(bool isOn, bool hasPower)
    {
        _isOn = isOn;
        _hasPower = hasPower;
    }

    public Device(Device device)
    {
        _isOn = device._isOn;
        _hasPower = device._hasPower;
    }

    public bool CanWork()
    {
        return _isOn || _hasPower;
    }

    public override string ToString()
    {
        return $"Turned on: {_isOn}, Receiving power: {_hasPower}";
    }
}
