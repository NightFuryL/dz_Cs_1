using System;
using dz_Cs_1.Exercise1;
using dz_Cs_1.Exercise2;
class Program
{
    static void Main()
    {
        #region HW 29.11.2025 - 06.12.2025
        //1.1
        IRemoteControl tv = new TvRemoteControl();
        tv.TurnOn();
        tv.SetChannel(5);
        tv.TurnOff();
        //1.2
        IRemoteControl radio = new RadioRemoteControl();
        radio.TurnOn();
        radio.SetChannel(101);
        radio.TurnOff();
        //2.1
        IValidator email = new EmailValidator("lev@mail.com");
        //2.2
        IValidator password = new PasswordValidator("(:password:)");
        Console.WriteLine("Email valid: " + email.Validate());
        Console.WriteLine("Password valid: " + password.Validate());
        #endregion
    }
}
