# How to use DevExpress Reporting Components in Blazor applications

This example demonstrates how to integrate the [HTML5 Document Viewer](https://docs.devexpress.com/XtraReports/400248) and [End-User Report Designer](https://docs.devexpress.com/XtraReports/400249) into a Blazor application.

The solution is based on the client-server model and includes the **BlazorReporting.Client** and **BlazorReporting.Server** parts.

**Note:** DevExpress Blazor components are now free-of-charge, but you need a corresponding [DevExpress subscription](https://www.devexpress.com/buy/net/) to use the Reporting tools.


## Solution's Server Part

An ASP.NET Core application that processes requests from the Document Viewer and Report Designer and provides a report storage. 

These are the main steps to configure the server side: 
1. Install the **DevExpress.AspNetCore.Reporting** and **Microsoft.AspNetCore.Mvc.NewtonsoftJson** NuGet packages.
2. Create a controller with an action that creates the Report Designer model.
3. [Implement a report storage](https://docs.devexpress.com/XtraReports/400211).
4. Register reporting services and the report storage in the **Startup** class.

_Files to look at:_
* [ReportingController.cs](./CS/BlazorReporting/Server/Controllers/ReportingController.cs)
* [CustomReportStorageWebExtension.cs](./CS/BlazorReporting/Server/CustomReportStorageWebExtension.cs)
* [ReportFactory.cs](./CS/BlazorReporting/Server/ReportFactory.cs)
* [Startup.cs](./CS/BlazorReporting/Server/Startup.cs)

## Solution's Client Part

Defines the UI for the Document Viewer and Report Designer and implements the logic to respond to UI updates. 

These are the main steps to configure the client side: 
1. Install the **devexpress-reporting**, **@devexpress/analytics-core** and **devextreme** npm packages. 
2. Create the **\*.razor** files for the Report Designer and Document Viewer. To render these components, use the [dxReportViewer](https://docs.devexpress.com/XtraReports/118985) and [dxReportDesigner](https://docs.devexpress.com/XtraReports/400255) bindings. For both components, invoke an initialization method in the **OnAfterRender** lifecycle event and release unused memory in the **Dispose** event.
3. Create the ***.js** file and implement the logic to initialize and dispose of components. 
4. Import required CSS styles.
5. (Optionally) Add the **webpack.config.js** file and create a bundle with [Webpack](https://webpack.js.org/).


_Files to look at:_
* [package.json](./CS/BlazorReporting/Client/package.json)
* [Viewer.razor](./CS/BlazorReporting/Client/Pages/Viewer.razor)
* [Designer.razor](./CS/BlazorReporting/Client/Pages/Designer.razor)
* [index.js](./CS/BlazorReporting/Client/index.js)
* [style.css](./CS/BlazorReporting/Client/style.css)
* [webpack.config.js](./CS/BlazorReporting/Client/webpack.config.js)
* [NavMenu.razor](./CS/BlazorReporting/Client/Shared/NavMenu.razor)
