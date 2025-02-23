using System.Reflection.Metadata;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Text;

namespace Demo_And_Notes
{
    internal class Program
    {
        //.NET : Unified Development Platform 
        // 1.Common Base Libraries
        // 2.Infrastructure [Runtime components - Compilers - Languages]

        // Asp.net has 3 projects :
        //Mvc 
        //Razor
        //Web Api 

        //.net blazor 
        // Server app : multiple
        // Web Assembly : SPA

        //MVC Components
        //Model : Represents database tables(C# classes).
        //View : Represents HTML pages.
        //Controller : Functions

        //A controller is a class that inherits from Controller.
        //The name must end with "Controller".
        //Contains public non-static functions called Actions.

        //Basic CRUD actions:

        //GetAll()
        //GetById()
        //Add()
        //Update()
        //Delete()

        //HTTP : HyperText transfer protocol [REquest and response]
        //FTP  : File transfer protocol
        //TCP  : Transmission control protocol

        //Https vs Http
        //Https is more secure

        //Url : Uniform Resource Locator
        //Http -> protocol
        //www -> Sub-Domain
        //Domain: name of website
        //TLD : .com/.net etc.

        //Uri = Urn + Url : Uniform Resource Identifier


        //Server : Computer or device its ip is accessible through the internet

        //A physical server : a dedicated, standalone hardware that runs an operating system and applications directly on its hardware.

        //Advantages:

        //High performance (direct access to hardware). 
        //More stable(no resource sharing).
        //Better for high workloads(databases, high-traffic websites).

        //Disadvantage : 

        //Expensive - Limited Scalability

        //Virtual Server : software-based machine running on a physical server using virtualization

        //Advantages:

        //Cost-efficient - Scalable - Backup & Recovery

        //Disadvantage : 

        //Shared resources - Security risks 

        //Http Messages 
        //1.Request

        //Request Line : Method + Path + Protocol + Version 
        // Methods : Get , Post , Put , Delete

        //2.Response
        //Status line 
        //100 - 199 -> Info
        //200 - 299 -> Successful
        //300 - 399 -> Redirection
        //400 - 499 -> Client Error
        //500 - 599 -> Server Error

        //ASP.NET Framework : [Web Forms - Web Pages - Mvc ]

        //ASP.NET Core : [Razor Pages - Mvc ]

        //ASP.NET SignalR : [Model - Controller ]

        //Kestrel : Internal Web Server
        //Used in reverse proxy configuration

        //Asp hosting : windows [IIS] - linux/mac [Apache-nginx]
    }
}
