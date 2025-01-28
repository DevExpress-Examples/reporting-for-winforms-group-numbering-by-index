Namespace ReportingExpressionFunctions

    Partial Class Report1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportingExpressionFunctions.Report1))
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.checkBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me.table1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryName"
            table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""184"" />"
            table3.Name = "Categories"
            columnExpression1.Table = table3
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            table5.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""284"" />"
            table5.Name = "Products"
            columnExpression2.Table = table5
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "UnitPrice"
            columnExpression3.Table = table5
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Discontinued"
            columnExpression4.Table = table5
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "ProductSales"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table5
            join1.Parent = table3
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table5)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo1.StyleName = "PageInfo"
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Discontinued", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 27F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.BorderWidth = 0F
            Me.tableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GroupIndex(1) + 1 + '.' + (GroupIndex(0) + 1)")})
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "GroupCaption1"
            Me.tableCell1.StylePriority.UseBorderWidth = False
            Me.tableCell1.Text = "DISCONTINUED"
            Me.tableCell1.Weight = 998175.13820974878R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.BorderWidth = 0F
            Me.tableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox1})
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.tableCell2.StyleName = "GroupData1"
            Me.tableCell2.StylePriority.UseBorderWidth = False
            Me.tableCell2.StylePriority.UsePadding = False
            Me.tableCell2.Weight = 11211401.773188636R
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AnchorHorizontal = CType(((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.checkBox1.AnchorVertical = CType(((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.checkBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.checkBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Discontinued]")})
            Me.checkBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2.026558E-05F)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.SizeF = New System.Drawing.SizeF(581.6669F, 24.99996F)
            Me.checkBox1.StylePriority.UseBorders = False
            Me.checkBox1.Text = "Discontinued"
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
            Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader2.HeightF = 27F
            Me.GroupHeader2.Level = 1
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
            Me.table2.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2, Me.tableCell3, Me.tableCell4})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GroupIndex(1) + 1")})
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StyleName = "GroupCaption1"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.095570433456316384R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "GroupCaption1"
            Me.tableCell3.Text = "CATEGORY NAME"
            Me.tableCell3.Weight = 0.29939752025063743R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "GroupData1"
            Me.tableCell4.Weight = 0.77404015457880349R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            ' 
            ' table4
            ' 
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table4.Name = "table4"
            Me.table4.OddStyleName = "DetailData3_Odd"
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
            Me.table4.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.tableCell7, Me.tableCell8})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GroupIndex(1) + 1 + '.' + (GroupIndex(0) + 1) + '.' + (CurrentRowIndexInGroup(0) " & "+ 1)")})
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StyleName = "DetailData1"
            Me.xrTableCell1.StylePriority.UseBorders = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.1288367333224319R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailData1"
            Me.tableCell7.StylePriority.UseBorders = False
            Me.tableCell7.Weight = 1.0229973261727605R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData1"
            Me.tableCell8.StylePriority.UseTextAlignment = False
            Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell8.TextFormatString = "{0:C2}"
            Me.tableCell8.Weight = 0.42408297025240382R
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New DevExpress.Drawing.DXFont("Arial", 14.25F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.Title.Name = "Title"
            Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' GroupCaption1
            ' 
            Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((162)))))), (CInt(((CByte((162)))))), (CInt(((CByte((162)))))))
            Me.GroupCaption1.BorderColor = System.Drawing.Color.White
            Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupCaption1.BorderWidth = 2F
            Me.GroupCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((228)))))), (CInt(((CByte((228)))))))
            Me.GroupCaption1.Name = "GroupCaption1"
            Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupData1
            ' 
            Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((162)))))), (CInt(((CByte((162)))))), (CInt(((CByte((162)))))))
            Me.GroupData1.BorderColor = System.Drawing.Color.White
            Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupData1.BorderWidth = 2F
            Me.GroupData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupData1.ForeColor = System.Drawing.Color.White
            Me.GroupData1.Name = "GroupData1"
            Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption1
            ' 
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2F
            Me.DetailCaption1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData1
            ' 
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2F
            Me.DetailData1.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupFooterBackground3
            ' 
            Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((137)))))), (CInt(((CByte((137)))))), (CInt(((CByte((137)))))))
            Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
            Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupFooterBackground3.BorderWidth = 2F
            Me.GroupFooterBackground3.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((228)))))), (CInt(((CByte((228)))))), (CInt(((CByte((228)))))))
            Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
            Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((231)))))), (CInt(((CByte((231)))))), (CInt(((CByte((231)))))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((75)))))), (CInt(((CByte((75)))))), (CInt(((CByte((75)))))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            ' 
            ' Report1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupHeader2, Me.Detail})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "ProductSales"
            Me.DataSource = Me.sqlDataSource1
            Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75F)
            Me.PageColor = System.Drawing.SystemColors.Window
            Me.ReportPrintOptions.DetailCountAtDesignTime = 50
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "24.1"
            CType((Me.table1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table1 As DevExpress.XtraReports.UI.XRTable

        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private checkBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private table2 As DevExpress.XtraReports.UI.XRTable

        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private table4 As DevExpress.XtraReports.UI.XRTable

        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupData1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle

        Private GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle

        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    End Class
End Namespace
