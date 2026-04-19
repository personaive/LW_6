using System;

public class SmartDevice : Device
{
    private bool _isConnectedToWifi;

    public SmartDevice(bool isOn, bool hasPower,bool isConnectedToWifi)
        : base(isOn, hasPower)
    {
        _isConnectedToWifi = isConnectedToWifi;
    }

    public SmartDevice(SmartDevice other)
        : base(other)
    {
        _isConnectedToWifi = other._isConnectedToWifi;
    }

    public bool IsOnline()
    {
        return _isConnectedToWifi;
    }

    public bool IsSmartActive()
    {
        return CanWork() && _isConnectedToWifi;
    }

    public void ConnectToWifi()
    {
        _isConnectedToWifi = true;
    }

    public override string ToString()
    {
        return base.ToString() + $", Wi-Fi connected: {_isConnectedToWifi}";
    }
}
