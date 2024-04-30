<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/788382208/24.1.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1228736)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Visual Studio Report Designer - Group Numbering by Index

The following example generates a report with a multi-level numbered list. To achieve this report layout, report controls use `GroupIndex()` and `CurrentRowIndexInGroup()` functions within data binding expressions (to return group and row indexes).

The following image illustrates output for a report designed to group information by product category and discontinued state:

![](./images/report.png)

## Files to Review

- [Report1.cs](./CS/ReportingExpressionFunctions/Report1.cs) 
- [Report1.Designer.cs](./CS/ReportingExpressionFunctions/Report1.Designer.cs)   
- [Report1.resx](./CS/ReportingExpressionFunctions/Report1.resx)

## Documentation

- [Group Numbering by Index](https://docs.devexpress.com/XtraReports/404915/detailed-guide-to-devexpress-reporting/use-expressions/expressions-tasks-and-solutions/group-numbering-by-index?v=24.1)


