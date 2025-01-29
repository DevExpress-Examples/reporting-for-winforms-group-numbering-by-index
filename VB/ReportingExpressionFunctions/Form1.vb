Imports DevExpress.XtraReports.UI

Namespace ReportingExpressionFunctions

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim report As Report1 = New Report1()
            report.ShowRibbonPreviewDialog()
        End Sub
    End Class
End Namespace
