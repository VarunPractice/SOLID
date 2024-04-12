// See https://aka.ms/new-console-template for more information
using SOLID.OCP;

    Console.WriteLine("Hello, Enter License key to activate license!");
    var key = Console.ReadLine();
NormalLicense lic = new NormalLicense();
lic.ActivateLicense(key);
Console.WriteLine("Hello, Enter License key to renew license!");
var key1 = Console.ReadLine();
RenewableLicense renewLic=new RenewableLicense();
renewLic.RenewLic(key1);
