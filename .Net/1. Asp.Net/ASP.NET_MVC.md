***ASP.NET MVC***

MVC is an architectural patterns that contains model, view, controller components. Provides a clean separation of concerns among UI (Presentation layer), model (Transfer objects/Domain Objects/Entities) and Business Logic (Controller).
- Model — It’s a business entity and it is used to represent the application data. Business logic + Validation + Data access
- Controller — It takes the Requests from the user through view. The controller also processes the requests like DELETE, PUT, GET, POST.
- View — UI elements of an application



***Page life cycle of MVC***

- App initialization
- Routing
- Instantiate and execute controller
- Locate and invoke controller action
- Instantiate and render view.

- ***The Application Life Cycle*** : The application life cycle refers to the time at which the application process actually begins running IIS until the time it stops. This is marked by the application start and end events in the startup file of your application.

- ***The Request Life Cycle*** : It is a pipeline when a http or https request arrived through views.
The entry point for every MVC application begins with routing. After the ASP.NET platform has received a request, it figures out how it should be handled through the URL Routing Module.
Modules are .NET components that can hook into the application life cycle and add functionality. The routing module is responsible for matching the incoming URL to routes that we define in our application.
All routes have an associated route handler with them and this is the entry point to the MVC framework.
Route Handler
The MVC framework handles converting the route data into a concrete controller that can handle requests. After the controller has been created, the next major step is Action Execution. A component called the action invoker finds and selects an appropriate Action method to invoke the controller.
After our action result has been prepared, the next stage triggers, which is Result Execution. MVC separates declaring the result from executing the result. If the result is a view type, the View Engine will be called and it's responsible for finding and rending our view.
If the result is not a view, the action result will execute on its own. This Result Execution is what generates an actual response to the original HTTP request.

![image](https://user-images.githubusercontent.com/52479605/213848202-e3f82121-08cd-4e37-8af6-3a01861d6c6c.png)

1) ***HTTP Request***: Also called Hyper text transfer protocol. 
2) ***Routing***: When every time you send a request to an ASP.NET MVC application request stops by UrlRoutingModule
and routig modules decides which controller takes the request.
3) ***Controller***: According to routing information Controller controller returns view results
4) ***ViewResult***: View result calls view engine in order to render the view
6) ***ViewEngine*** : Converts cshtml(scripts, markups, razor view engines) files to html.
7) ***View***: Serves ui elements to users 

***Razor View Engine***
- Razor View Engine ia a markup syntax. Bu iş için kullanılan Razor Sözdizimi MVC uygulamalarımız içerisinde kolay bir şekilde HTML üretmemize yardımcı olur.
- Yazacağınız kod her zaman @{ … } içerisinde olmalı.
- Komutlarınızın sonunda noktalı virgül “;” bulunmalı.
- Kullandığınız dosyaların uzantısı .cshtml olmalı.
- Değişkenleriniz “var” anahtar sözcüğüyle tanımlanmış olmalı.
- Satır içi ifadeleriniz (değişkenler ve fonksiyonlar) “@” ile başlamalı.
- C# kodlarınız büyük-küçük harfe duyarlıdır.


***Razor View Engine***
- Razor view is a markup syntax or render for HTML
- Helps producing html
- The code always between @{...} 
- After every statement use ;
- Variables must be declared  [string testString = "Razor"] or [var testString = "Razor"]
- Variables and functions must be start with "@" 
- C# codes are case sensitive















