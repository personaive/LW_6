using System;

public class SmartDevice : Device // дочерний класс
{
    private bool _isConnectedToWifi;

    public SmartDevice(bool isOn, bool hasPower,bool isConnectedToWifi) // конструктор с параметрами
        : base(isOn, hasPower)
    {
        _isConnectedToWifi = isConnectedToWifi;
    }

    public SmartDevice(SmartDevice other) // конструктор копирования
        : base(other)
    {
        _isConnectedToWifi = other._isConnectedToWifi;
    }

    public bool IsOnline() // метод: подключено ли к сети
    {
        return _isConnectedToWifi;
    }

    public bool IsSmartActive() // метод: "умное устройство активно"
    {
        return CanWork() && _isConnectedToWifi;
    }

    public void ConnectToWifi() // метод: подключить к Wi-Fi
    {
        _isConnectedToWifi = true;
    }

    public override string ToString()
    {
        return base.ToString() + $", Wi-Fi connected: {_isConnectedToWifi}";
    }
}
