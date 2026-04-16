using System;

public class Device // класс с двумя логическими полями
{
    private bool _isOn;
    private bool _hasPower;

    public Device(bool isOn, bool hasPower) // конструктор с параметрами
    {
        _isOn = isOn;
        _hasPower = hasPower;
    }

    public Device(Device device) // конструктор копирования
    {
        _isOn = device._isOn;
        _hasPower = device._hasPower;
    }

    public bool CanWork() // метод дизъюнкции (логическое ИЛИ)
    {
        return _isOn || _hasPower;
    }

    public override string ToString() // перегрузка метода ToString()
    {
        return $"Turned on: {_isOn}, Receiving power: {_hasPower}";
    }
}