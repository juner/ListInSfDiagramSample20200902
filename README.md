# ListInSfDiagramSample
syncfusion SfDiagram (WPF) bug?

I can't set PageBackground of PageSettings to Transparent when I put SfDiagram in ListView. What do you know?

[-> Community Forum](https://www.syncfusion.com/forums/157491)


ScrollSettings and PageSettings properties were initialized with default values in the SfDiagram's Constructor. While you using SfDiagram as DataTemplate, the property which is already initialized doesn't gets updated for xaml values.  

So,we have solved this issue by creating custom class for SfDiagram and updated the properties in the constructor of the custom class. Then use that custom Diagram in the template to achieve your requirement.

[-> Community Forum](https://www.syncfusion.com/forums/157491/#275022)