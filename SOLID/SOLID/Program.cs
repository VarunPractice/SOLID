// See https://aka.ms/new-console-template for more information
using SOLID.DIP;
using SOLID.LSP;
using SOLID.OCP;

//    Console.WriteLine("Hello, Enter License key to activate license!");
//    var key = Console.ReadLine();
//NormalLicense lic = new NormalLicense();
//lic.ActivateLicense(key);
//Console.WriteLine("Hello, Enter License key to renew license!");
//var key1 = Console.ReadLine();
//RenewableLicense renewLic=new RenewableLicense();
//renewLic.RenewLic(key1);
IRenewablelLicense license = new SoftwareLicense();
license.InstallLicense("hello");
license.RenewLicense("hello");
license.ReturnInstalledLicense("hello");

SOLID.DIP.ILicense StatiClic = new HardwareLicense();
StatiClic.InstallLicense("hello");
StatiClic.ReturnInstalledLicense("Hello");

    IUnit unit = new PressureUnit();
unit.convert(unit, 23.7, unit, 23); 
