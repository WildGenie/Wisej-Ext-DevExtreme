# <img src="https://wisej.com/wp-content/uploads/2018/09/Wisej-Black.png" height="42" align="top"/> Wisej-DevExtreme

DevExtreme includes a comprehensive collection of high-performance and responsive UI widgets for use in traditional web and next-gen mobile applications. The suite ships with a feature-complete data grid, interactive charts widgets, data editors, and much more. With DevExtreme, you’ll deliver amazing user experiences for today’s modern web browsers.


## Concept
For the premium Syncfusion, DevExtreme, and Telerik KendoUI integration packages we have used an approach different from the other integrations we publish on the open Wisej repositories. In this case we wanted to use all the features that are available to javascript, angular, react, blazor developers instead of trying to build a limited .NET object hierarchy.

When you look at the code, you will find a common base class **ejBase** for all the widgets classes. Overloaded constructors that indicate which ej1 class to use, and a number of initialization options that may be different for some widgets.

The ejBase class uses a custom **wisej.web.ext.DevExtreme** implementation that takes care of the creation and registration of events, methods, and templates. It also provides some simple methods to override in each derived class.

Each specific class has it's own nested .js file that may add specific functionality to filter event data to make it serializable for the server, make sure the wrapped widget fits the container, and whatever else may be needed to make the integration as smooth as possible.

All the premium extensions are open projects, meaning that we will keep adding, fixing, changing, and expanding them according to the requirements of our Technology Partners and needs we find on our projects using these extensions.

## License
To use this extension you need to acquire at least a **JavaScript Bundle** license from DevExpress: https://js.devexpress.com/Buy/.

## Demo
Not yet available

## Work in progress
The library and test are in progress - we are adding every available widget to the test app and will keep refining the intergration for the foreseable future.

## How to use
All the integrated widgets have 3 types of members: options, methods, and events. The options (you'll find them under "Configuration" in the API Reference documentation) are represented by a single javascript map. Methods are javascript functions. Events in the DevExtreme widgets are callback methods defined in the options map.

### Options
When using the dx classes in your .NET Wisej application, you have access to the entire set of options using a single property, Options. It is a dynamic .NET object and you can use it directly or assign it.

When you set the Options using the designer, you can simply copy and paste (and edit) any JSON string.

When you set (or change) the Options by code, you can

- Assign the fields directly using the built-in dynamic objects,
- Assign an object that has the properties you want to use,
- Assign an anonymous class.

Assigning the fields directly will automatically update the widget on the client when the property that changes is on the first level. In case your code changes properties deeper than the first level in the hierarchy, you need to call widget1.Update().

~~~
this.dxCircularGauge1.Options.containerBackgroundColor = "blue";

this.dxCircularGauge1.Options.scale.startValue = 0;
this.dxCircularGauge1.Options.scale.endValue = 50;
this.dxCircularGauge1.Update();
~~~

The function BuildRanges() in the code sample below returns a .NET array of .NET classes with the members that match the fields expected by the dxCircularGauge widget.

~~~
this.dxCircularGauge1.Options.rangeContainer.ranges = buildRanges();
~~~

Anonymous classes (example below) allow for a syntax very similar to javascript. However, once you assign an anonymous class instance, you cannot change the value of it's properties. To change a value you have to reassign the anonymous object.

~~~
this.dxCircularGauge1.Options.rangeContainer.ranges = new object[] {
    new { startValue = 50, endValue = 90 },
    new { startValue = 90, endValue = 130 },
    new { startValue = 130, endValue = 150 }
};
~~~

You will find the complete set of options at the DevExpress docs site linked below. Each dx class in the source code also include a direct link to the docs API and Concept pages.

### Methods

### Events

## Support
To log issues related to this extension, please use the Issues section of this repository. To log issues related to the usage of this extension in your projects, please use the Issues section in your Technology Partner repository.

You may also fork this project and modify it to fit your needs and if you want to share a change or fix, please create a pull request.

## Documentation

DevExtreme Documentation:

https://js.devexpress.com/Documentation/

DevExtreme API:

https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/

DevExtreme Demos:

https://js.devexpress.com/Demos/WidgetsGallery/

## Redistribution

We have bundled the entire set of JS widgets, themes, and assets in the Wisej.Web.Ext.DevExtreme assembly as embedded resources. You need to deploy only 1 assembly and your client devices don't need an open internet connection.

## Update

The DevExtreme assets are located in /JavaScript using the same directory structure used in the installation zip you receive from DevExpress when you purchase the license. To update the version of the JS library, simply copy the files over and recompile the project.



---
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.
